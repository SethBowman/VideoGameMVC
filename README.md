# Video Game App

## Overview

Video Game App is a web application developed using C#, ASP.NET Core MVC, and MySQL database. It employs Dapper as an ORM (Object-Relational Mapping) tool. The application allows users to perform CRUD (Create, Read, Update, Delete) operations on video games.

## Features

- **Create**: Add new video games to the database.
- **Read**: View details of existing video games.
- **Update**: Edit information about existing video games.
- **Delete**: Remove video games from the database.

## Technologies Used

- **C#**: Programming language used for application development.
- **ASP.NET Core MVC**: Framework for building web applications and APIs.
- **MySQL**: Relational database management system for storing video game data.
- **Dapper**: Lightweight ORM for data access.

## Prerequisites

- .NET SDK
- MySQL Server
- MySQL Workbench (optional, for database management)
- Visual Studio or any other C# IDE

## Setup Instructions

1. **Clone the Repository**
   ```bash
   git clone https://github.com/SethBowman/VideoGameMVC.git
   cd VideoGameMVC
   ```

2. **Setup MySQL Database**
   - Install MySQL Server if not already installed.
   - Create a new database using the following SQL script:

     ```sql
     -- Drop the existing database if it exists
     DROP DATABASE IF EXISTS video_games;

     -- Create a new database named video_games
     CREATE DATABASE video_games;
     USE video_games;

     -- Create the games table with genre, release_year, and platform columns
     CREATE TABLE games (
         id INT AUTO_INCREMENT PRIMARY KEY,
         title VARCHAR(255) NOT NULL,
         genre VARCHAR(100),
         release_year INT,
         platform VARCHAR(50),
         imgURL VARCHAR(255)
     );

     -- Insert the specified games with titles, genre, release_year, platform, and image URLs
     INSERT INTO games (title, genre, release_year, platform, imgURL)
     VALUES
         ('The Legend of Zelda: Breath of the Wild', 'Action-Adventure', 2017, 'Nintendo Switch', 'https://upload.wikimedia.org/wikipedia/en/c/c6/The_Legend_of_Zelda_Breath_of_the_Wild.jpg'),
         ('God of War (2018)', 'Action-Adventure', 2018, 'PlayStation 4', 'https://upload.wikimedia.org/wikipedia/en/a/a7/God_of_War_4_cover.jpg'),
         ('Grand Theft Auto V', 'Action-Adventure', 2013, 'Multi-platform', 'https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png'),
         ('Minecraft', 'Sandbox', 2011, 'Multi-platform', 'https://upload.wikimedia.org/wikipedia/en/5/51/Minecraft_cover.png'),
         ('Overwatch', 'First-Person Shooter', 2016, 'Xbox One', 'https://upload.wikimedia.org/wikipedia/en/5/51/Overwatch_cover_art.jpg'),
         ('Cyberpunk 2077', 'Action RPG', 2020, 'Multi-platform', 'https://upload.wikimedia.org/wikipedia/en/9/9f/Cyberpunk_2077_box_art.jpg'),
         ('The Last of Us', 'Action-Adventure', 2013, 'PlayStation 3', 'https://upload.wikimedia.org/wikipedia/en/4/46/Video_Game_Cover_-_The_Last_of_Us.jpg'),
         ('Red Dead Redemption 2', 'Action-Adventure', 2018, 'Xbox One', 'https://upload.wikimedia.org/wikipedia/en/4/44/Red_Dead_Redemption_II.jpg'),
         ('The Elder Scrolls V: Skyrim', 'Action RPG', 2011, 'Multi-platform', 'https://upload.wikimedia.org/wikipedia/en/1/15/The_Elder_Scrolls_V_Skyrim_cover.png');

     -- Query to check the inserted data
     SELECT * FROM games;
     ```

   - Create a `appsettings.json` file in the root directory of the project and add your MySQL connection string:
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=your_server;Database=video_games;User=your_username;Password=your_password;"
       }
     }
     ```

3. **Install Dependencies**
   ```bash
   dotnet restore
   ```

4. **Run the Application**
   ```bash
   dotnet run
   ```

5. **Open the Application**
   - Open a web browser and navigate to `http://localhost:5000` to see the application in action.

## Project Structure

- **Controllers**: Contains the MVC controllers responsible for handling user requests.
- **Models**: Contains the data models representing video games.
- **Views**: Contains the Razor views for rendering HTML.
- **Repositories**: Contains the Dapper-based repository classes for data access.
- **wwwroot**: Contains static files like CSS, JS, and images.
- **appsettings.json**: Configuration file for application settings, including database connection strings.

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Create a new Pull Request.

## Contact

For any inquiries or feedback, please reach out to [sbowman@truecoders.io].

## Screenshots 

![index](https://github.com/SethBowman/VideoGameMVC/assets/81124768/272aa6af-eb21-4f62-98ea-4beab8d889ed)

![view](https://github.com/SethBowman/VideoGameMVC/assets/81124768/64d2ea1c-1133-40c0-9742-509fb62e16d0)

![create](https://github.com/SethBowman/VideoGameMVC/assets/81124768/7359d69d-9cfb-4602-833c-c38179e2b2ce)

![udate](https://github.com/SethBowman/VideoGameMVC/assets/81124768/6318a256-e51b-4c8c-8727-a7ac686ad555)


---
