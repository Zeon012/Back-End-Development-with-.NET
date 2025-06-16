# User Management API

This project is an ASP.NET Core Web API for managing users. It provides a set of CRUD (Create, Read, Update, Delete) endpoints to handle user-related operations.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [License](#license)

## Installation

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd UserManagementAPI
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

## Usage

Once the application is running, you can access the API at `http://localhost:5146`. Use tools like Postman or curl to interact with the API endpoints.

## API Endpoints

- **GET /api/users**: Retrieve a list of users.
- **GET /api/users/{id}**: Retrieve a specific user by ID.
- **POST /api/users**: Create a new user.
- **PUT /api/users/{id}**: Update an existing user.
- **DELETE /api/users/{id}**: Delete a user.

## Contributing

Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.