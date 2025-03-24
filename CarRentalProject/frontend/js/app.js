async function fetchCars() {
    const response = await fetch('http://localhost:5000/api/cars');
    const cars = await response.json();
    document.getElementById('car-list').innerHTML = cars.map(car => `
        <div>
            <h3>${car.model}</h3>
            <p>Price per day: $${car.price_per_day}</p>
        </div>
    `).join('');
}