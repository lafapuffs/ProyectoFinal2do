-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 20, 2026 at 06:20 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `proyectin`
--

-- --------------------------------------------------------

--
-- Table structure for table `modulos`
--

CREATE TABLE `modulos` (
  `id` int(11) NOT NULL,
  `nombre_es` varchar(100) DEFAULT NULL,
  `nombre_en` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `modulos`
--

INSERT INTO `modulos` (`id`, `nombre_es`, `nombre_en`) VALUES
(1, 'Antropologia', 'Anthropology'),
(2, 'Calculo', 'Calculus'),
(3, 'Deporte', 'Sports'),
(4, 'Arquitectura', 'Arquitecture');

-- --------------------------------------------------------

--
-- Table structure for table `preguntas_antropologia`
--

CREATE TABLE `preguntas_antropologia` (
  `id` int(11) NOT NULL,
  `pregunta` varchar(255) NOT NULL,
  `opcion_a` varchar(100) NOT NULL,
  `opcion_b` varchar(100) NOT NULL,
  `opcion_c` varchar(100) NOT NULL,
  `opcion_d` varchar(100) NOT NULL,
  `respuesta_correcta` char(1) NOT NULL,
  `pregunta_en` text DEFAULT NULL,
  `opcion_a_en` varchar(255) DEFAULT NULL,
  `opcion_b_en` varchar(255) DEFAULT NULL,
  `opcion_c_en` varchar(255) DEFAULT NULL,
  `opcion_d_en` varchar(255) DEFAULT NULL,
  `imagen_ruta` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `preguntas_antropologia`
--

INSERT INTO `preguntas_antropologia` (`id`, `pregunta`, `opcion_a`, `opcion_b`, `opcion_c`, `opcion_d`, `respuesta_correcta`, `pregunta_en`, `opcion_a_en`, `opcion_b_en`, `opcion_c_en`, `opcion_d_en`, `imagen_ruta`) VALUES
(1, '¿Qué estudia la antropología?', 'La cultura y evolución humana', 'Las matemáticas aplicadas', 'El hardware de computadoras', 'Las leyes de la física', 'A', 'What does Anthropology study?', 'Human Culture and Evolution', 'Math', 'Computers', 'Physics', NULL),
(0, '¿En qué se diferencia principalmente el intercambio en una sociedad tradicional frente al comercio moderno?', 'En que en las sociedades tradicionales el intercambio crea y mantiene lazos sociales.', 'En que el comercio moderno solo usa el trueque.', 'En que antes no existía ningún tipo de valor para los objetos.', 'En que la antropología no considera importante la economía.', 'A', 'What is the main difference between exchange in a traditional society compared to modern commerce?', 'In traditional societies, exchange creates and maintains social bonds.', 'Modern commerce only uses barter.', 'Objects had no value of any kind in the past.', 'Anthropology does not consider economics to be important.', NULL),
(0, '¿Qué caracteriza a una sociedad con una estructura de \"Banda\" o \"Tribu\" en comparación con un Estado?', 'Tienen liderazgos más informales basados en el prestigio o parentesco.', 'Tienen un presidente elegido por votos electrónicos.', 'Tienen leyes escritas en constituciones complejas.', 'Tienen ejércitos profesionales permanentes.', 'A', 'What characterizes a society with a \"Band\" or \"Tribe\" structure compared to a State?', 'They have more informal leadership based on prestige or kinship.', 'They have a president elected by electronic voting.', 'They have written laws in complex constitutions.', 'They have permanent professional armies.', NULL),
(0, '¿Cuál es la importancia de la gastronomía (como la arepa o la hallaca) para la identidad cultural del venezolano?', 'Sirve como un símbolo de unión y diferenciación cultural frente a otros países.', 'Es simplemente una forma de alimentarse sin mayor significado.', 'Es algo que se inventó recientemente para el turismo.', 'No tiene relación con el estudio de la antropología.', 'A', 'What is the importance of gastronomy (such as the arepa or the hallaca) for the cultural identity of Venezuelans?', 'It serves as a symbol of unity and cultural differentiation from other countries.', 'It is simply a way of eating without any major meaning.', 'It is something that was recently invented for tourism.', 'It has no relationship with the study of anthropology.', NULL),
(0, '¿Cuál es la función social de realizar un velorio o ceremonia tras el fallecimiento de alguien?', 'Ayudar a la comunidad y a la familia a procesar la pérdida y reorganizar el grupo social.', 'Es un trámite obligatorio para poder usar el cementerio.', 'Es un evento exclusivamente diseñado para gastar dinero.', 'Solo sirve para que los antropólogos tengan algo que escribir.', 'A', 'What is the social function of holding a wake or ceremony after someone passes away?', 'To help the community and the family process the loss and reorganize the social group.', 'It is a mandatory procedure to be allowed to use the cemetery.', 'It is an event exclusively designed to spend money.', 'It only serves to give anthropologists something to write about.', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `preguntas_arquitectura`
--

CREATE TABLE `preguntas_arquitectura` (
  `id` int(11) NOT NULL,
  `pregunta` varchar(255) NOT NULL,
  `opcion_a` varchar(100) NOT NULL,
  `opcion_b` varchar(100) NOT NULL,
  `opcion_c` varchar(100) NOT NULL,
  `opcion_d` varchar(100) NOT NULL,
  `respuesta_correcta` char(1) NOT NULL,
  `pregunta_en` text DEFAULT NULL,
  `opcion_a_en` varchar(255) DEFAULT NULL,
  `opcion_b_en` varchar(255) DEFAULT NULL,
  `opcion_c_en` varchar(255) DEFAULT NULL,
  `opcion_d_en` varchar(255) DEFAULT NULL,
  `imagen_ruta` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `preguntas_arquitectura`
--

INSERT INTO `preguntas_arquitectura` (`id`, `pregunta`, `opcion_a`, `opcion_b`, `opcion_c`, `opcion_d`, `respuesta_correcta`, `pregunta_en`, `opcion_a_en`, `opcion_b_en`, `opcion_c_en`, `opcion_d_en`, `imagen_ruta`) VALUES
(1, 'Que es esto?', 'Memoria RAM', 'Disco Duro', 'Tarjeta Grafica', 'Procesador', 'A', 'What is this?', 'RAM Memory', 'Hard Drive', 'Graphic Card', 'Processor', 'C:\\Users\\rafae\\OneDrive\\Documentos\\SharpDevelop Projects\\ProyectoEducativo\\ProyectoEducativo\\bin\\Debug\\ImagenesModuloArquitectura\\Pregunta1.jpg'),
(2, 'Observa este componente. ¿Por qué se le conoce frecuentemente como el \"cerebro\" de la computadora?', 'Porque interpreta y ejecuta todas las instrucciones de los programas.', 'Porque es el encargado de dar energía a todos los ventiladores.', 'Porque es donde se guardan permanentemente todas las fotos y videos.', 'Porque conecta la computadora con el monitor de forma inalámbrica.', 'A', 'Look at this component. Why is it frequently known as the \"brain\" of the computer?', 'Because it interprets and executes all program instructions.', 'Because it is responsible for powering all the cooling fans.', 'Because it is where all photos and videos are permanently saved.', 'Because it connects the computer to the monitor wirelessly.', NULL),
(3, 'Al ver este módulo de memoria, ¿cuál es su característica principal en cuanto al almacenamiento?', 'Es una memoria de acceso rápido que se borra al apagar el equipo.', 'Guarda la información para siempre, incluso si apagas la computadora.', 'Es mucho más lenta que un disco duro pero tiene más capacidad.', 'Solo sirve para que la computadora encienda más rápido.', 'A', 'Looking at this memory module, what is its main characteristic regarding storage?', 'It is a high-speed access memory that is cleared when the computer is turned off.', 'It saves information forever, even if you turn off the computer.', 'It is much slower than a hard drive but has more capacity.', 'It only serves to make the computer turn on faster.', NULL),
(4, 'En el esquema de la tarjeta madre se ven varias líneas que conectan los componentes. ¿Cuál es la función de estos \"Buses\"?', 'Transportar la información digital entre los distintos componentes (CPU, RAM, etc).', 'Transportar la electricidad desde la fuente de poder.', 'Enfriar el procesador mediante aire a presión.', 'Sostener físicamente las piezas para que no se caigan.', 'A', 'In the motherboard diagram, you can see several lines connecting the components. What is the function of these \"Buses\"?', 'To transport digital information between different components (CPU, RAM, etc.).', 'To transport electricity from the power supply unit.', 'To cool down the processor using pressurized air.', 'To physically hold the parts so they do not fall out.', NULL),
(5, 'Observa el teclado y el monitor en el diagrama. ¿Cómo interactúan con la CPU según la arquitectura básica?', 'El teclado envía datos (entrada) y el monitor muestra resultados (salida).', 'Ambos son encargados de procesar la lógica matemática.', 'El monitor le da instrucciones al teclado para que escriba solo.', 'No tienen ninguna relación con el funcionamiento del procesador.', 'A', 'Look at the keyboard and the monitor in the diagram. How do they interact with the CPU according to basic architecture?', 'The keyboard sends data (input) and the monitor displays results (output).', 'Both are responsible for processing mathematical logic.', 'The monitor gives instructions to the keyboard so it types on its own.', 'They have no relationship with the operation of the processor.', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `preguntas_calculo`
--

CREATE TABLE `preguntas_calculo` (
  `id` int(11) NOT NULL,
  `pregunta` varchar(255) NOT NULL,
  `opcion_a` varchar(100) NOT NULL,
  `opcion_b` varchar(100) NOT NULL,
  `opcion_c` varchar(100) NOT NULL,
  `opcion_d` varchar(100) NOT NULL,
  `respuesta_correcta` char(1) NOT NULL,
  `pregunta_en` text DEFAULT NULL,
  `opcion_a_en` varchar(255) DEFAULT NULL,
  `opcion_b_en` varchar(255) DEFAULT NULL,
  `opcion_c_en` varchar(255) DEFAULT NULL,
  `opcion_d_en` varchar(255) DEFAULT NULL,
  `imagen_ruta` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `preguntas_calculo`
--

INSERT INTO `preguntas_calculo` (`id`, `pregunta`, `opcion_a`, `opcion_b`, `opcion_c`, `opcion_d`, `respuesta_correcta`, `pregunta_en`, `opcion_a_en`, `opcion_b_en`, `opcion_c_en`, `opcion_d_en`, `imagen_ruta`) VALUES
(1, '¿Cual es la derivada de x²?', '2x', 'x', 'x²', '2', 'A', 'What is the derivate of x²?', '2x', 'x', 'x²', '2', NULL),
(2, 'Si al evaluar un límite directamente te da una forma de 0/0, ¿qué significa esto?', 'Que el límite es igual a cero.', 'Que el límite no existe bajo ninguna circunstancia.', 'Que hay una indeterminación y se debe simplificar o factorizar la función.', 'Que la función es una línea recta horizontal.', 'C', 'If evaluating a limit directly gives you a 0/0 form, what does this mean?', 'The limit is equal to zero.', 'The limit does not exist under any circumstances.', 'There is an indeteminacy, and the function must be simplified or factored.', 'The function is a horizontal straight line.', ''),
(3, 'Si al evaluar un límite directamente te da una forma de 0/0, ¿qué significa esto?', 'Que hay una indeterminación y se debe simplificar o factorizar la función.', 'Que el límite es igual a cero.', 'Que el límite no existe bajo ninguna circunstancia.', 'Que la función es una línea recta horizontal.', 'A', 'If evaluating a limit directly gives you a 0/0 form, what does this mean?', 'There is an indeteminacy, and the function must be simplified or factored.', 'The limit is equal to zero.', 'The limit does not exist under any circumstances.', 'The function is a horizontal straight line.', NULL),
(4, '¿Cuál es la regla básica para derivar una potencia como x a la n (x^n)?', 'Se baja el exponente a multiplicar y se le resta 1 al exponente original.', 'Se le suma 1 al exponente y se divide por el mismo número.', 'El resultado siempre es 1.', 'Se multiplica el exponente por x sin cambiar nada más.', 'A', 'What is the basic rule for differentiating a power like x to the n (x^n)?', 'You bring the exponent down to multiply and subtract 1 from the original exponent.', 'You add 1 to the exponent and divide by that same number.', 'The result is always 1.', 'You multiply the exponent by x without changing anything else.', NULL),
(5, '¿Qué información nos da la pendiente de la recta tangente a una curva en un punto específico?', 'El valor de la derivada en ese punto.', 'El valor máximo del rango.', 'El punto donde la función corta al eje Y.', 'El dominio total de la función.', 'A', 'What information does the slope of the tangent line to a curve at a specific point give us?', 'The value of the derivative at that point.', 'The maximum value of the range.', 'The point where the function crosses the Y-axis.', 'The total domain of the function.', NULL),
(6, '¿Cómo se identifica una función constante en una gráfica?', 'Es una línea recta horizontal que no sube ni baja.', 'Es una línea perfectamente vertical.', 'Es una curva que siempre sube hacia la derecha.', 'Es un círculo centrado en el origen.', 'A', 'How do you identify a constant function on a graph?', 'It is a horizontal straight line that does not go up or down.', 'It is a perfectly vertical line.', 'It is a curve that always goes up to the right.', 'It is a circle centered at the origin.', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `preguntas_deporte`
--

CREATE TABLE `preguntas_deporte` (
  `id` int(11) NOT NULL,
  `pregunta` varchar(255) NOT NULL,
  `opcion_a` varchar(100) NOT NULL,
  `opcion_b` varchar(100) NOT NULL,
  `opcion_c` varchar(100) NOT NULL,
  `opcion_d` varchar(100) NOT NULL,
  `respuesta_correcta` char(1) NOT NULL,
  `pregunta_en` text DEFAULT NULL,
  `opcion_a_en` varchar(255) DEFAULT NULL,
  `opcion_b_en` varchar(255) DEFAULT NULL,
  `opcion_c_en` varchar(255) DEFAULT NULL,
  `opcion_d_en` varchar(255) DEFAULT NULL,
  `imagen_ruta` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `preguntas_deporte`
--

INSERT INTO `preguntas_deporte` (`id`, `pregunta`, `opcion_a`, `opcion_b`, `opcion_c`, `opcion_d`, `respuesta_correcta`, `pregunta_en`, `opcion_a_en`, `opcion_b_en`, `opcion_c_en`, `opcion_d_en`, `imagen_ruta`) VALUES
(1, '¿Cuantos jugadores ingresan por equipo en la cancha en un juego de Baloncesto?', '6', '5', '8', '10', 'B', 'How many players per team enter the court in a basketball game?', '6', '5', '8', '10', ''),
(2, '¿Qué sucede si el jugador que batea en la Pelotica e\' Goma lanza la pelota fuera de los límites del terreno de juego?', 'Se considera un \"foul\" o fuera, igual que en el béisbol.', 'Se le otorga un \"Home Run\" automático.', 'El equipo contrario gana el partido inmediatamente.', 'Se debe cambiar la pelota por una de tenis.', 'A', 'What happens if the player who is batting in Pelotica e\' Goma hits the ball outside the boundaries of the field?', 'It is considered a foul or out, just like in baseball.', 'They are awarded an automatic Home Run.', 'The opposing team wins the game immediately.', 'The ball must be exchanged for a tennis ball.', NULL),
(3, '¿Cómo se inicia el juego de balonmano después de que un equipo marca un gol?', 'Con un saque de centro por parte del equipo que recibió el gol.', 'Con un saque desde la arquería del equipo que recibió el gol.', 'Con un tiro de esquina.', 'Con un salto entre dos jugadores en el medio de la cancha.', 'A', 'How does a handball game restart after a team scores a goal?', 'With a throw-off from the center line by the team that conceded the goal.', 'With a throw-in from the goal area of the team that conceded the goal.', 'With a corner throw.', 'With a jump ball between two players in the middle of the court.', NULL),
(4, '¿Cuántos toques máximos puede dar un equipo al balón antes de pasarlo al campo contrario (sin contar el bloqueo)?', '3 toques.', '2 toques.', '4 toques.', 'Toques ilimitados mientras el balón no caiga.', 'A', 'What is the maximum number of hits a team can give to the ball before sending it to the opponent\'s court (not counting the block)?', '3 hits.', '2 hits.', '4 hits.', 'Unlimited hits as long as the ball does not touch the ground.', NULL),
(5, '¿Qué castigo recibe un jugador si comete una falta muy grave o acumula dos tarjetas amarillas?', 'Se le muestra la tarjeta roja y debe abandonar el campo.', 'Se le da una advertencia verbal y sigue jugando.', 'Debe sentarse en la banca por 5 minutos y luego volver.', 'El equipo contrario gana un tiro libre desde el medio campo.', 'A', 'What punishment does a player receive if they commit a very serious foul or accumulate two yellow cards?', 'They are shown the red card and must leave the field.', 'They are given a verbal warning and keep playing.', 'They must sit on the bench for 5 minutes and then return.', 'The opposing team gets a free kick from the midfield line.', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `rol`
--

CREATE TABLE `rol` (
  `administrador` int(11) NOT NULL,
  `jugador` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `clave` varchar(50) NOT NULL,
  `rol` int(11) NOT NULL,
  `puntaje` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`id`, `nombre`, `clave`, `rol`, `puntaje`) VALUES
(1, 'rafa', '1234', 1, 0),
(5, 'maria', '1212', 2, 40),
(7, 'dai', '1234', 1, 0),
(8, 'cesar', '2426', 2, 45),
(9, 'Ana', '2301', 2, 25);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `preguntas_arquitectura`
--
ALTER TABLE `preguntas_arquitectura`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `preguntas_calculo`
--
ALTER TABLE `preguntas_calculo`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `preguntas_deporte`
--
ALTER TABLE `preguntas_deporte`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `preguntas_arquitectura`
--
ALTER TABLE `preguntas_arquitectura`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `preguntas_calculo`
--
ALTER TABLE `preguntas_calculo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `preguntas_deporte`
--
ALTER TABLE `preguntas_deporte`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
