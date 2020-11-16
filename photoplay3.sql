-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-04-2018 a las 23:45:09
-- Versión del servidor: 10.1.30-MariaDB
-- Versión de PHP: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `photoplay3`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bonusruleta`
--

CREATE TABLE `bonusruleta` (
  `IdBonusRuleta` int(11) NOT NULL,
  `Foto1` varchar(128) NOT NULL,
  `Foto2` varchar(128) NOT NULL,
  `Foto3` varchar(128) NOT NULL,
  `Foto4` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dificultades`
--

CREATE TABLE `dificultades` (
  `IdDificultad` int(11) NOT NULL,
  `Nombre` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `dificultades`
--

INSERT INTO `dificultades` (`IdDificultad`, `Nombre`) VALUES
(1, 'Facil'),
(2, 'Medio'),
(3, 'Dificil'),
(4, 'Muy dificil');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `jugadores`
--

CREATE TABLE `jugadores` (
  `IdJugador` int(11) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Record` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `jugadores`
--

INSERT INTO `jugadores` (`IdJugador`, `Nombre`, `Record`) VALUES
(1, 'Pepito', 2320),
(2, 'Carlitos', 2540),
(3, 'Sandrita', 2500),
(4, 'Pablito', 1470),
(5, 'Pepin', 1580),
(6, 'dfas', 6543),
(7, 'ProPlayer', 7563),
(8, 'Gato', 7234),
(9, 'PikassoLegit', 45962),
(10, 'AlphaTester', 4312),
(11, 'BetaTester', 1343),
(12, 'GammaTester', 342),
(13, 'DeltaTester', 774),
(14, 'EpsilonTester', 412),
(15, 'ZetaTester', 811),
(16, 'Pepito', 364),
(17, 'EtaTester', 26527),
(18, 'Juanito', 30801),
(19, 'ghkldjsf', 39935),
(20, 'marcelo', 2104),
(21, 'mfjhm', 2684),
(22, 'mfjhm', 0),
(23, 'mfjhm', 0),
(24, 'mfjhm', 0),
(25, 'mfjhm', 1887),
(26, 'mfjhm', 1926),
(27, 'mfjhm', 0),
(28, 'mfjhm', 0),
(29, 'ProSniperxxx360', 40829),
(30, 'ProSniperxxx360', 45558),
(31, 'ProSniperxxx360', 45119),
(32, 'ProPlayteyhr', 45304);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `partida`
--

CREATE TABLE `partida` (
  `IdPartida` int(11) NOT NULL,
  `Jugador` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntapartida`
--

CREATE TABLE `preguntapartida` (
  `IdPreguntaPartida` int(11) NOT NULL,
  `Pregunta` int(11) DEFAULT NULL,
  `Partida` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntas`
--

CREATE TABLE `preguntas` (
  `IdPregunta` int(11) NOT NULL,
  `Pregunta` varchar(256) NOT NULL,
  `Respuesta1` varchar(64) NOT NULL,
  `Respuesta2` varchar(64) NOT NULL,
  `Respuesta3` varchar(64) NOT NULL,
  `Respuesta4` varchar(64) NOT NULL,
  `RespuestaCorrecta` int(1) NOT NULL,
  `Foto` varchar(128) NOT NULL,
  `Pista` varchar(128) DEFAULT NULL,
  `Dificultad` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntas`
--

INSERT INTO `preguntas` (`IdPregunta`, `Pregunta`, `Respuesta1`, `Respuesta2`, `Respuesta3`, `Respuesta4`, `RespuestaCorrecta`, `Foto`, `Pista`, `Dificultad`) VALUES
(1, '¿Cuál es el río más largo del mundo?', 'Janeiro', 'Nilo', 'Amazonas', 'Mississippi', 3, 'Fotos\\1.png', NULL, 1),
(2, '¿Quién es el padre del psicoanálisis?', 'Sigmund Froud', 'Sigmund Freud', 'Peter Gay', 'Petter Gay', 2, 'Fotos\\2.jpg', NULL, 1),
(3, '¿Cuál es el país más grande del mundo?', 'Estados Unidos', 'Canadá', 'China', 'Rusia', 4, 'Fotos\\3.png', NULL, 1),
(4, '¿En qué país se encuentra este monumento?', 'India', 'Mongolia', 'Tailandia', 'China', 1, 'Fotos\\4.jpg', NULL, 1),
(5, '¿Cómo se llama la nota marcada?', 'Mi', 'Fa', 'Sol', 'La', 4, 'Fotos\\5.jpg', NULL, 4),
(6, '¿Quién es?', 'Ludvig van Bethoveen', 'Ludwig van Beethoven', 'Wolfgang Amadeus Mozart', 'Wolfang Amadeus Mozärt', 2, 'Fotos\\6.jpg', NULL, 1),
(7, '¿Cuántos nervios diferentes recogen el gusto?', '2', '1', '4', '3', 4, 'Fotos\\7.png', NULL, 4),
(8, '¿Cuántos corazones tiene un pulpo?', '2', '3', '1', '4', 2, 'Fotos\\8.jpg', NULL, 2),
(9, '¿Qué ocupa más, un litro de agua o aceite?', '1L de agua', '1L de aceite', 'Lo mismo', '$', 3, 'Fotos\\9.jpg', NULL, 1),
(10, '¿Cuál es el récord en resolver este puzle?', '4,56 segundos', '3,23 segundos', '0,49 segundos', '1,98 segundos', 3, 'Fotos\\10.png', NULL, 4),
(11, 'Los 5 sabores que detectamos son: dulce, salado, ácido, amargo y...', 'Munami', 'Salargo', 'Kunami', 'Umami', 4, 'Fotos\\11.jpg', NULL, 4),
(12, '¿Cuál es el lugar más frío de la tierra?', 'Cima del Everest', 'Polo Norte', 'Antártida', 'Oymyakon (Rusia)', 3, 'Fotos\\12.jpg', NULL, 2),
(13, '¿Quién escribió La Odisea?', 'Hesíodo', 'Homero', 'Pausanias', 'Tucídides', 2, 'Fotos\\13.jpg', NULL, 2),
(14, '¿Cuántos huesos hay un cuerpo humano adulto?', '204', '206', '304', '306', 2, 'Fotos\\14.png', NULL, 2),
(15, '¿Quién pintó este cuadro?', 'Miguel Ángel', 'Leonardo da Vinci', 'Pullock', 'Francesco Ricci', 2, 'Fotos\\15.jpg', NULL, 2),
(16, '¿En qué año se descubrió América?', '1942', '1492', '1429', '1249', 2, 'Fotos\\16.png', NULL, 1),
(17, '¿Qué es la cartografía?', 'Es el arte de diseñar cartas', 'Es la afición de coleccionar cartas', 'Es la ciencia que estudia los mapas', 'Es la especialización del manejo de barajas', 3, 'Fotos\\17.png', NULL, 1),
(18, '¿Cuánto duró la Guerra de los Cien Años?', '100 años', '126 años', '116 años', '106 años', 3, 'Fotos\\23.jpg', NULL, 4),
(19, '¿Qué país fabrica los sombreros panamá?', 'Panamá', 'Ecuador', 'Venezuela', 'Guatemala', 2, 'Fotos\\19.png', NULL, 4),
(20, '¿Dónde se obtiene el catgut?', 'Del abdomen de arácnidos', 'De las raíces de sequoia', 'De los intestinos de caballos u ovejas', 'De los intestinos de gatos', 3, 'Fotos\\20.jpg', 'Es una fibra utilizada en cirugía. Cat=gato, gut=intestino', 4),
(21, '¿Cuál era el nombre del rey Jorge VI?', 'Alberto', 'Jorge', 'Santiago', 'Jorgelino', 1, 'Fotos\\21.png', 'El rey respetó el deseo de la reina Victoria de que ningún rey fuera, en el futuro, llamado de esta manera', 4),
(22, '¿De dónde provienen las grosellas chinas?', 'China', 'Laos', 'Taiwán', 'Nueva Zelanda', 4, 'Fotos\\22.jpg', NULL, 4),
(23, '¿Cuál fue la duración de la Guerra de los Treinta Años?', '30 años', '33 años', '31 años', '36 años', 1, 'Fotos\\23.jpg', NULL, 4),
(24, '¿Cuántas letras tiene el alfabeto hawaiano?', '21', '12', '18', '24', 2, 'Fotos\\24.jpg', NULL, 4),
(25, '¿Qué instrumento es este?', 'Banjo eléctrico', 'Bajo eléctrico', 'Guitarra eléctrica', 'Laúd eléctrico', 2, 'Fotos\\25.png', NULL, 1),
(26, '¿Qué película no fue protagonizada por  Leslie Nielsen?', 'Agárralo como puedas', 'Agárralo como puedas 2', 'Agárralo como puedas 2 y 1/2', 'Aterriza como puedas', 2, 'Fotos\\26.jpg', NULL, 4),
(27, '¿Qué no fue Leonardo Da Vinci?', 'Urbanista', 'Botánico', 'Sociólogo', 'Paleontólogo', 3, 'Fotos\\27.png', NULL, 4),
(28, '¿Qué palabras forman las siglas JPEG?', 'Joint Portable Extension Graphics', 'Joint Photographical Exploited Graphics', 'Joint Portable Extension Group ', 'Joint Photographic Experts Group', 4, 'Fotos\\28.png', NULL, 4),
(29, '¿Cuál es el roedor más grande?', 'Castor siberiano', 'Caípu', 'Carpincho', 'Puercoespín crespado', 3, 'Fotos\\29.gif', NULL, 4),
(30, '¿Cómo se conjuga el verbo roer en 1ª persona?', 'Yo rollo', 'Yo roo', 'Yo rayo', 'Yo roho', 2, 'Fotos\\30.png', NULL, 2),
(31, '¿En qué ciudad se sitúa?', 'Valencia', 'Barcelona', 'Londres', 'París', 4, 'Fotos\\36.jpg', NULL, 2),
(32, '¿Cuál es la capital de Madagascar?', 'Morondava', 'Kiranomena', 'Manakara', 'Antananarivo', 4, 'Fotos\\31.png', NULL, 4),
(33, '¿Quién pintó este cuadro?', 'Leonardo da Vinci', 'Van Gogh', 'Monet', 'Miguel Ángel', 2, 'Fotos\\32.jpg', NULL, 2),
(34, '¿Cuántos patos había?', '0', '1', '2', '3', 3, 'Fotos\\33.jpg', NULL, 3),
(35, '¿Dónde se situa el pozo?', 'Lado izquierdo', 'Lado derecho', 'Por el centro', 'No hay ningún pozo', 2, 'Fotos\\34.jpg', NULL, 3),
(36, '¿Cuántas casas aparecen?', '3', '6', '5', '4', 3, 'Fotos\\35.jpg', NULL, 3),
(37, '¿A qué obra pertenece esta frase?', 'Hamlet', 'Romeo y Julieta', 'Otelo', 'Macbeth', 1, 'Fotos\\37.png', NULL, 2),
(38, '¿En qué año fue la caída del muro de Berlín?', '1981', '1988', '1982', '1989', 4, 'Fotos\\38.jpg', NULL, 2),
(39, '¿Qué planeta no tiene anillos?', 'Venus', 'Júpiter', 'Saturno', 'Neptuno', 1, 'Fotos\\39.jpg', NULL, 2),
(40, '¿Cuántos kilos son una libra?', '1,25', 'La libra no es una unidad de peso', '0,65', '0,45', 4, 'Fotos\\40.png', NULL, 4),
(41, '¿En qué linea está el fallo?', '14', '11', '16', '4', 2, 'Fotos\\41.png', NULL, 2),
(42, '¿De qué color la punta de su cola?', 'Marrón', 'Negra', 'Roja', 'Amarilla', 4, 'Fotos\\42.gif', NULL, 2),
(43, '¿De qué color es la casa de la derecha?', 'Verde', 'Morada', 'Rosa', 'Naranja', 4, 'Fotos\\43.jpg', NULL, 3),
(44, '¿Cuál es el estado de la luna?', 'Nueva', 'Llena', 'Menguante', 'Creciente', 2, 'Fotos\\44.png', NULL, 3),
(45, '¿De qué color son las flores del arbol derecho?', 'Verdes', 'Rojas', 'Blancas', 'No tiene flores', 4, 'Fotos\\45.jpg', NULL, 3),
(46, '¿Cuántas cimas se ven?', '3', '5', '1', '$', 2, 'Fotos\\46.jpg', NULL, 3),
(47, '¿Cuántos pares de ojos se ven?', '0', '1', '2', '$', 2, 'Fotos\\50.jpg', NULL, 3),
(48, '¿Cuántos salvavidas hay?', '1', '4', '3', 'Ninguno', 3, 'Fotos\\47.jpg', NULL, 3),
(49, '¿A qué dirección va el windsurfista?', 'No hay ningún windsurfista', 'Izquierda', 'Derecha', '$', 1, 'Fotos\\48.jpg', NULL, 3),
(50, '¿Qué simboliza esta esvástica?', 'Símbolo sagrado del budismo', 'Emblema del nazismo alemán', 'Lauburu antiguo', '$', 1, 'Fotos\\49.jpg', NULL, 3),
(56, '¿Cuántos pares de ojos se ven?', '1', '2', '3', '0', 1, 'Fotos\\50.jpg', NULL, 3);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `bonusruleta`
--
ALTER TABLE `bonusruleta`
  ADD PRIMARY KEY (`IdBonusRuleta`);

--
-- Indices de la tabla `dificultades`
--
ALTER TABLE `dificultades`
  ADD PRIMARY KEY (`IdDificultad`);

--
-- Indices de la tabla `jugadores`
--
ALTER TABLE `jugadores`
  ADD PRIMARY KEY (`IdJugador`);

--
-- Indices de la tabla `partida`
--
ALTER TABLE `partida`
  ADD PRIMARY KEY (`IdPartida`),
  ADD KEY `Jugador` (`Jugador`);

--
-- Indices de la tabla `preguntapartida`
--
ALTER TABLE `preguntapartida`
  ADD PRIMARY KEY (`IdPreguntaPartida`),
  ADD KEY `Pregunta` (`Pregunta`),
  ADD KEY `Partida` (`Partida`);

--
-- Indices de la tabla `preguntas`
--
ALTER TABLE `preguntas`
  ADD PRIMARY KEY (`IdPregunta`),
  ADD KEY `Dificultad` (`Dificultad`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `bonusruleta`
--
ALTER TABLE `bonusruleta`
  MODIFY `IdBonusRuleta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `dificultades`
--
ALTER TABLE `dificultades`
  MODIFY `IdDificultad` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `jugadores`
--
ALTER TABLE `jugadores`
  MODIFY `IdJugador` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT de la tabla `partida`
--
ALTER TABLE `partida`
  MODIFY `IdPartida` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `preguntapartida`
--
ALTER TABLE `preguntapartida`
  MODIFY `IdPreguntaPartida` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `preguntas`
--
ALTER TABLE `preguntas`
  MODIFY `IdPregunta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `partida`
--
ALTER TABLE `partida`
  ADD CONSTRAINT `partida_ibfk_1` FOREIGN KEY (`Jugador`) REFERENCES `jugadores` (`IdJugador`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `preguntapartida`
--
ALTER TABLE `preguntapartida`
  ADD CONSTRAINT `preguntapartida_ibfk_1` FOREIGN KEY (`Partida`) REFERENCES `partida` (`IdPartida`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `preguntapartida_ibfk_2` FOREIGN KEY (`Pregunta`) REFERENCES `preguntas` (`IdPregunta`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `preguntas`
--
ALTER TABLE `preguntas`
  ADD CONSTRAINT `preguntas_ibfk_1` FOREIGN KEY (`Dificultad`) REFERENCES `dificultades` (`IdDificultad`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
