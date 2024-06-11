# Car Inventory API

This is a .NET 8 API that lists an inventory of cars, reading the values from a JSON file that emulates a database.

## Table of Contents
- [Overview](#overview)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Example JSON File](#example-json-file)
- [Contributing](#contributing)
- [License](#license)

## Overview
The Car Inventory API provides endpoints to list all cars, list sold cars, list cars by year, and list cars that cost less than a given value. It reads the car data from a JSON file, which serves as a mock database.

## Installation
1. Clone the repository:
    ```bash
    git clone https://github.com/your-username/car-inventory-api.git
    ```
2. Navigate to the project directory:
    ```bash
    cd car-inventory-api
    ```
3. Restore the dependencies:
    ```bash
    dotnet restore
    ```
4. Build the project:
    ```bash
    dotnet build
    ```

## Usage
1. Ensure you have .NET 8 SDK installed.
2. Place your JSON file (`cars.json`) in the project directory. An example structure of the JSON file is provided below.
3. Run the API:
    ```bash
    dotnet run
    ```
4. The API will be available at `https://localhost:5001` or `http://localhost:5000`.

## API Endpoints

### List All Cars
- **Endpoint:** `/api/Cars`
- **Method:** GET
- **Description:** Returns a list of all cars in the inventory.
- **Example Request:**
    ```bash
    GET /api/Cars
    ```

### List All Sold Cars
- **Endpoint:** `/api/Cars/sold`
- **Method:** GET
- **Description:** Returns a list of all sold cars.
- **Example Request:**
    ```bash
    GET /api/Cars/sold
    ```

### List Cars by Year
- **Endpoint:** `/api/Cars/byYear/{year}`
- **Method:** GET
- **Description:** Returns a list of all cars manufactured in the specified year.
- **Example Request:**
    ```bash
    GET /api/Cars/byYear/2020
    ```

### List Cars by Amount
- **Endpoint:** `/api/Cars/byAmount/{amount}`
- **Method:** GET
- **Description:** Returns a list of all cars that cost less than the specified amount.
- **Example Request:**
    ```bash
    GET /api/Cars/byAmount/20000
    ```

## Example JSON File
Place a file named `cars.json` in the root of your project directory with the following structure:

```json
[
    {
        "id": 1,
        "make": "Toyota",
        "model": "Camry",
        "year": 2020,
        "price": 24000,
        "isSold": false
    },
    {
        "id": 2,
        "make": "Honda",
        "model": "Civic",
        "year": 2019,
        "price": 18000,
        "isSold": true
    },
    {
        "id": 3,
        "make": "Ford",
        "model": "Mustang",
        "year": 2021,
        "price": 32000,
        "isSold": false
    }
]
