window.ontaxiNavbarScroll = () => {
     const navbar = document.querySelector('.navbar-custom');
     if (!navbar) return;

     const onScroll = () => {
          if (window.scrollY > 10) {
               navbar.classList.add('scrolled');
          } else {
               navbar.classList.remove('scrolled');
          }
     };

     window.addEventListener('scroll', onScroll);

     // Run once on load in case the page is already scrolled
     onScroll();
};


window.observeFadeIn = () => {
     const elements = document.querySelectorAll('.fade-in-up');
     if (!('IntersectionObserver' in window)) {
          // Fallback: show all
          elements.forEach(el => el.classList.add('visible'));
          return;
     }
     const observer = new IntersectionObserver((entries, obs) => {
          entries.forEach(entry => {
               if (entry.isIntersecting) {
                    entry.target.classList.add('visible');
                    obs.unobserve(entry.target);
               }
          });
     }, { threshold: 0.1 });
     elements.forEach(el => observer.observe(el));
};



window.showTripOnMap = function (from, to) {
     // Location data must match C# LocationInfo names
     const locations = {
          "Vlorë": [40.454602, 19.484542],
          "Kaninë": [40.4431, 19.4897],
          "Panaja": [40.4892, 19.5312],
          "Radhimë": [40.3931, 19.4786],
          "Zvërnec": [40.5072, 19.4006],
          "Orikum": [40.3331, 19.4717],
          "Tragjas": [40.323682, 19.510902],
          "Dukat": [40.252243, 19.565015],
          "Llogara": [40.2206, 19.5631],
          "Palasë": [40.1592718, 19.6020328],
          "Dhërmi": [40.1531, 19.6342],
          "Himarë": [40.1022, 19.7447],
          "Sarandë": [39.8756, 20.0059],
          "Ksamil": [39.8667, 20.0167],
          "Fier": [40.7239, 19.5561],
          "Berat": [40.7058, 19.9522],
          "Gjirokastër": [40.0758, 20.1389],
          "Korçë": [40.6186, 20.7808],
          "Kukës": [42.0769, 20.4219],
          "Shkodër": [42.0683, 19.5126],
          "Durrës": [41.3231, 19.4414],
          "Elbasan": [41.1125, 20.0828],
          "Lezhë": [41.7836, 19.6436],
          "Peshkopi": [41.6850, 20.4281],
          "Tirana": [41.3275, 19.8187],
          "TIA Airport 🛫": [41.4147, 19.7206],
          "Prishtinë": [42.6629, 21.1655],
     };

     const fromCoords = locations[from.trim()];
     const toCoords = locations[to.trim()];

     if (!fromCoords || !toCoords) {
          alert('Coordinates not found for this trip.');
          return;
     }

     // Set modal title
     document.getElementById('mapModalTitle').textContent = from + ' → ' + to;
     document.getElementById('mapModal').style.display = 'flex';

     // Remove previous map instance
     if (window.tripMapInstance) {
          window.tripMapInstance.remove();
          window.tripMapInstance = null;
     }

     // Initialize map
     window.tripMapInstance = L.map('tripMap').setView(fromCoords, 9);

     // Add OpenStreetMap tiles
     L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
          attribution: '&copy; OpenStreetMap contributors'
     }).addTo(window.tripMapInstance);

     // Add markers
     L.marker(fromCoords).addTo(window.tripMapInstance).bindPopup(from).openPopup();
     L.marker(toCoords).addTo(window.tripMapInstance).bindPopup(to);

     // Fetch route from OSRM
     const url = `https://router.project-osrm.org/route/v1/driving/${fromCoords[1]},${fromCoords[0]};${toCoords[1]},${toCoords[0]}?overview=full&geometries=geojson`;
     fetch(url)
          .then(res => res.json())
          .then(data => {
               if (data.routes && data.routes.length > 0) {
                    const route = data.routes[0].geometry;
                    const distanceMeters = data.routes[0].distance;
                    const distanceKm = (distanceMeters / 1000).toFixed(2);

                    L.geoJSON(route, { color: 'green', weight: 4 }).addTo(window.tripMapInstance);
                    window.tripMapInstance.fitBounds(L.geoJSON(route).getBounds(), { padding: [50, 50] });

                    document.getElementById('mapModalTitle').textContent =
                         `${from} → ${to} (${distanceKm} km)`;
               } else {
                    alert('No route found.');
               }
          })
          .catch(() => alert('Failed to fetch route.'));
};

window.closeMapModal = function () {
     document.getElementById('mapModal').style.display = 'none';
     if (window.tripMapInstance) {
          window.tripMapInstance.remove();
          window.tripMapInstance = null;
     }
};
