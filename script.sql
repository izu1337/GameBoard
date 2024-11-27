-- Création de la base de données 
CREATE DATABASE game_db;

-- Connexion à la DB
\c game_db;

CREATE TABLE platforms (
    id SERIAL PRIMARY KEY,
    code VARCHAR(50) NOT NULL,
    name VARCHAR(100) NOT NULL
);

CREATE TABLE games (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    editor VARCHAR(100) NOT NULL,
    rate DECIMAL(3, 2) NOT NULL,
    nb_rates INT NOT NULL
);

-- la table de liaison entre les jeux et les plateformess
CREATE TABLE game_platforms (
    game_id INT REFERENCES games(id) ON DELETE CASCADE,
    platform_id INT REFERENCES platforms(id) ON DELETE CASCADE,
    PRIMARY KEY (game_id, platform_id)
);


INSERT INTO platforms (code, name) VALUES 
('pc', 'PC'),
('ps4', 'Playstation 4'),
('ps5', 'Playstation 5'),
('xbox', 'XBOX'),
('switch', 'Switch');

INSERT INTO games (name, editor, rate, nb_rates) VALUES
('The Witcher 3', 'CD Projekt Red', 4.7, 121400),
('Spider-Man', 'Insomniac Games', 4.5, 100000),
('Minecraft', 'Mojang', 4.8, 150000),
('God of War', 'Santa Monica Studio', 4.7, 121400),
('Animal Crossing', 'Nintendo', 4.5, 100000);

-- Liaison des platformes en fonction des jeux
INSERT INTO game_platforms (game_id, platform_id) VALUES
(1, 1), (1, 2), (1, 3), 
(2, 2), (2, 3), 
(3, 1), (3, 4),
(4, 3), (4, 5),
(5, 5);
