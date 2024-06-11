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
    git clone https://github.com/rogerioanselmo/testApi.git
    ```
2. Navigate to the project directory:
    ```bash
    cd testApi
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
Place a file named `data.json` inside ./CarsApi/API.Service/Data with the following structure:

```json
{
    "inventory": [
        {
            "manufacturer": "Ford",
            "items": [
                {
                    "sku": 1000,
                    "model": "Mustang",
                    "year": 2020,
                    "color": "red",
                    "cost": 15343,
                    "status": "Sold"
                },
                {
                    "sku": 1001,
                    "model": "Mustang",
                    "year": 2018,
                    "color": "blue",
                    "cost": 13499,
                    "status": "Unsold"
                },
                {
                    "sku": 1301,
                    "model": "Ranger",
                    "year": 2014,
                    "color": "blue",
                    "cost": 12499,
                    "status": "Unsold"
                }
            ]
        },
        {
            "manufacturer": "Fiat",
            "items": [
                {
                    "sku": 2000,
                    "model": "Urbana",
                    "year": 2020,
                    "color": "red",
                    "cost": 15343,
                    "status": "Sold"
                },
                {
                    "sku": 2001,
                    "model": "Pop",
                    "year": 2018,
                    "color": "blue",
                    "cost": 13499,
                    "status": "Preparing"
                },
                {
                    "sku": 2031,
                    "model": "Pop",
                    "year": 2019,
                    "color": "white",
                    "cost": 10999,
                    "status": "Unsold"
                },
                {
                    "sku": "Lounge",
                    "model": "Ranger",
                    "year": 2016,
                    "color": "silver",
                    "cost": 11499,
                    "status": "Unsold"
                }
            ]
        },
        {
            "manufacturer": "Volkswagon",
            "items": [
                {
                    "sku": 3031,
                    "model": "Tiguan",
                    "year": 2019,
                    "color": "silver",
                    "cost": 19999,
                    "status": "Unsold"
                },
                {
                    "sku": 3423,
                    "model": "Jetta",	
                    "year": 2024,
                    "color": "blue",
                    "cost": 21499,
                    "status": "Sale Pending"
                }
            ]
        }
    ]
}
