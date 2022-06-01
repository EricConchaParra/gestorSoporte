-- --------------------------------------------------------
-- Host:                         192.168.2.1
-- Versión del servidor:         8.0.29 - MySQL Community Server - GPL
-- SO del servidor:              Linux
-- HeidiSQL Versión:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Volcando estructura para tabla smanager2.ayuda
CREATE TABLE IF NOT EXISTS `ayuda` (
  `id` int NOT NULL AUTO_INCREMENT,
  `tema` char(10) NOT NULL,
  `contenido` mediumtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Volcando datos para la tabla smanager2.ayuda: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `ayuda` DISABLE KEYS */;
INSERT INTO `ayuda` (`id`, `tema`, `contenido`) VALUES
	(1, 'ssh', 'Para copiar texto del portapapeles a Putty, se debe hacer clic con el botón secundario en la pantalla de Putty.\r\n\r\n=== Detener Samba ===\r\n/etc/init.d/samba stop\r\n\r\n=== Reiniciar Samba ===\r\n/etc/init.d/samba start\r\n\r\n(Si no reconoce "samba stop" o "samba start" puede ser que tiene la versión 5.8 de samba, entonces debe usarse "smbd start" o "smbd stop").\r\n\r\n=== Comando para vincular Play ===\r\n\r\nexport PATH=$PATH:ruta_a_play\r\n\r\n=== Detener Play con Kill ===\r\nAveces es necesario detener play “a la mala”\r\n\r\nps –ax | grep play (fijarse en numero de proceso que diga java, por lo general con una descripción larga, fijarse en el Process ID -pid-)\r\n\r\nkill -9 <pid> escribir el numero del proceso reemplazando “<pid>”\r\n\r\n=== Comprimir en la terminal ===\r\ntar -zcvf nombre-archivo.tar.gz nombre-directorio\r\n\r\n=== Descomprimir en la terminal ===\r\ntar -xvzf miarcho.tar.gz\r\n\r\n=== Buscar archivo por consola ===\r\nfind / -name /lib/libc.so*\r\n\r\nfind / -name nombre_archivo* \r\n(El asterisco es un comodin)\r\n\r\n=== Espacio disponible en partición ===\r\ndf -lh\r\n\r\n=== Comprimir MySQL DB ===\r\nmysqldump –u nombre_usuario –p  nombre_DB | gzip > /la_ruta/nombre.sql.gz\r\n\r\n=== Descomprimir MySQL DB ===\r\ngunzip < /la_ruta/nombre.sql.gz | mysql –u nombre_usuario –p nombre_DB\r\n\r\n=== Cambiar Hora Servidor ===\r\n\r\nQuita primero el control a la máquina, que lo tenga el usuario\r\n    timedatectl set-ntp false\r\n\r\nCambiar fecha Hora...\r\n   date -s "2019-04-10 23:40"\r\n\r\nCopia Hora System a Hora HW\r\n   hwclock --systohc\r\n\r\n=== Para monitorear las consultas MySQL al servidor ===\r\n\r\nmysqladmin -u root -pclave -i 1 processlist\r\n'),
	(2, 'caf', '=== Pestaña "Diponibilidad" ===\r\n\r\nAquí se puede revisar los folios diponibles por cada tipo de documento.\r\n\r\nPara calculuar los meses que cubre la cantidad de folios diponibles se hace un recuento de los folios utilizandos en los últimos 30 días calendario y se hace un recuento de los utilizados en los últimos 90 días y se divide por 3. De los dos números se elige el más alto y los folios diponibles se dividen en esa cantidad, eso da como resultado la cantidad de meses para los que hay folios disponibles.\r\n\r\nCuando la disponibilidad en meses es menor a 1, se coloca de color rojo.\r\n\r\nCuando para cubrir la cantidad de meses proyectados se requiere pedir un número de folios, el número está morado.\r\n\r\nCuando para cubrir la cantidad de meses proyectados sobran folios, el número está negativo.\r\n\r\n=== Pestaña "Vencimiento" ===\r\n\r\nNota. Solo los CAF de "aquellos DTE que dan derecho a crédito fiscal" tienen fecha de vencimiento. Por lo tanto las boletas, facturas exentas y Guías de Despacho no tienen fecha de vencimiento.\r\n\r\nLa fila se coloca de color amarillo cuando los CAF están a 1 mes de vencer (es decir, tiene ya 5 meses).\r\n\r\nLa fila se coloca de color rojo cuando los CAF están vencidos (es decir, ya tienen 6 o más meses)\r\n');
/*!40000 ALTER TABLE `ayuda` ENABLE KEYS */;

-- Volcando estructura para tabla smanager2.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `rut` char(10) NOT NULL,
  `razon_social` char(50) NOT NULL,
  `fantasia` char(30) NOT NULL,
  `c_comercial` text,
  `c_tecnico` text,
  `c_adm_sistema` text,
  `notas` text,
  `funcionario` char(2) NOT NULL,
  `assm` char(1) NOT NULL,
  `gdrive` text,
  `erp` char(1) DEFAULT NULL,
  `erp_fecha_actual` date DEFAULT NULL,
  `dte` char(1) DEFAULT NULL,
  `cert_autorizado` text,
  `cert_vencimiento` date DEFAULT NULL,
  `dte_fecha_actual` date DEFAULT NULL,
  `hosting` char(1) DEFAULT NULL,
  `hosting_fecha_vence` date DEFAULT NULL,
  `activo` char(1) NOT NULL,
  PRIMARY KEY (`rut`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Volcando datos para la tabla smanager2.clientes: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando estructura para tabla smanager2.enlaces
CREATE TABLE IF NOT EXISTS `enlaces` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` char(60) NOT NULL,
  `url` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Volcando datos para la tabla smanager2.enlaces: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `enlaces` DISABLE KEYS */;
INSERT INTO `enlaces` (`id`, `nombre`, `url`) VALUES
	(1, 'SII - Solicitud de Folios', 'https://palena.sii.cl/cvc_cgi/dte/of_solicita_folios'),
	(2, 'SII - Anluación Masiva de Folios', 'https://www4.sii.cl/anulacionMsvDteInternet/');
/*!40000 ALTER TABLE `enlaces` ENABLE KEYS */;

-- Volcando estructura para tabla smanager2.funcionarios
CREATE TABLE IF NOT EXISTS `funcionarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` char(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Volcando datos para la tabla smanager2.funcionarios: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `funcionarios` DISABLE KEYS */;
INSERT INTO `funcionarios` (`id`, `nombre`) VALUES
	(1, 'Sin Asignar'),
	(2, 'Eric Concha');
/*!40000 ALTER TABLE `funcionarios` ENABLE KEYS */;

-- Volcando estructura para tabla smanager2.sql_queries
CREATE TABLE IF NOT EXISTS `sql_queries` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` char(80) NOT NULL,
  `query` mediumtext NOT NULL,
  `tipo` char(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Volcando datos para la tabla smanager2.sql_queries: ~13 rows (aproximadamente)
/*!40000 ALTER TABLE `sql_queries` DISABLE KEYS */;
INSERT INTO `sql_queries` (`id`, `nombre`, `query`, `tipo`) VALUES
	(1, 'DTE - Total DTE por estado', 'SELECT \r\n    FORMAT(SUM(CASE\r\n        WHEN estado_sii = 1 THEN 1\r\n        ELSE 0\r\n    END),0) AS \'Aceptado\',\r\n    SUM(CASE\r\n        WHEN estado_sii = 2 THEN 1\r\n        ELSE 0\r\n    END) AS \'Reparos\',\r\n    SUM(CASE\r\n        WHEN estado_sii = 4 THEN 1\r\n        ELSE 0\r\n    END) AS \'Enviado\',\r\n    SUM(CASE\r\n        WHEN estado_sii = 0 THEN 1\r\n        ELSE 0\r\n    END) AS \'NoEnviado\',\r\n    SUM(CASE\r\n        WHEN estado_sii = 3 THEN 1\r\n        ELSE 0\r\n    END) AS \'Rechazado\',\r\n    SUM(CASE\r\n        WHEN estado_sii = 99 THEN 1\r\n        ELSE 0\r\n    END) AS \'ErrorEnvio\',\r\n    FORMAT(COUNT(*),0) as Total_Emitidos\r\n    FROM\r\n		documentos\r\n	WHERE\r\n		is_received = 0;', '1'),
	(2, 'DTE - Documentos a resolver', 'SELECT \r\n    id_doc,\r\n    CASE\r\n	WHEN tipo_doc = 33 THEN \'FE\'\r\n	WHEN tipo_doc = 52 THEN \'GE\'\r\n	WHEN tipo_doc = 61 THEN \'NC\'\r\n	WHEN tipo_doc = 56 THEN \'ND\'\r\n	WHEN tipo_doc = 46 THEN \'F-Com\'\r\n    ELSE tipo_doc \r\n    END as \'tipo_doc\',\r\n    folio,\r\n    DATE_FORMAT(fch_emis,"%Y-%m-%d") as \'fch_emis\',\r\n    CASE\r\n		WHEN estado_sii = 0 THEN \'No Enviado\'\r\n		WHEN estado_sii = 3 THEN \'Rechazado\'\r\n		WHEN estado_sii = 99 THEN \'Error de Envio\'\r\n	ELSE estado_sii END \'estado_sii\'\r\n    \r\n    FROM\r\n		documentos\r\n	WHERE\r\n		estado_sii = 0 or\r\n		estado_sii = 3 or\r\n        estado_sii = 99\r\nORDER BY fch_emis desc\r\nLIMIT 100;', '1'),
	(3, 'DTE - Folios disponibles', 'SELECT \r\n	s.nombre,\r\n	CASE\r\n		WHEN tipo_doc = 33 THEN \'FE\'\r\n		WHEN tipo_doc = 52 THEN \'GE\'\r\n		WHEN tipo_doc = 61 THEN \'NC\'\r\n		WHEN tipo_doc = 56 THEN \'ND\'\r\n		WHEN tipo_doc = 39 THEN \'BE\'\r\n		WHEN tipo_doc = 46 THEN \'F-Com\'\r\n		WHEN tipo_doc = 34 THEN \'F-Ex\'\r\n    ELSE tipo_doc END as \'tipo_doc\',\r\n    FORMAT(rf.disponibles,0) as disponibles\r\nFROM resumen_folios as rf\r\nINNER JOIN sucursales as s ON rf.sucursales_id = s.id\r\nORDER BY s.nombre, rf.disponibles asc;', '1'),
	(4, 'DTE - Folios Boletas Repetidos', 'SELECT id, folio, tipo_doc, utilizado, sucursal_id\r\nFROM detalle_folios\r\nWHERE tipo_doc = 39 and folio\r\n    IN (\r\n    SELECT folio\r\n    FROM detalle_folios\r\n    GROUP BY folio\r\n    HAVING count( folio ) >1\r\n    )\r\nand utilizado = 0\r\nORDER BY folio;', '1'),
	(13, 'SManager - Firmas por vencimiento', 'select \n\nclientes.rut, clientes.fantasia, funcionarios.nombre as funcionario, clientes.cert_autorizado, clientes.cert_vencimiento \n\nfrom clientes\n\ninner join funcionarios on clientes.funcionario = funcionarios.id\n\nwhere dte = "1"\n\norder by cert_vencimiento asc;', '3'),
	(14, 'SManager - Clientes Hosting por Vencimiento', 'select clientes.rut, clientes.fantasia, funcionarios.nombre as funcionario, clientes.hosting_fecha_vence \r\nfrom clientes\r\ninner join funcionarios\r\non clientes.funcionario = funcionarios.id\r\nwhere hosting = "1"\r\norder by hosting_fecha_vence asc;', '3'),
	(17, 'SManager - Clientes ERP por Fecha Actualizacion', 'select clientes.rut, clientes.fantasia, funcionarios.nombre as funcionario, clientes.erp_fecha_actual \r\nfrom clientes\r\ninner join funcionarios\r\non clientes.funcionario = funcionarios.id\r\nwhere erp = "1"\r\norder by erp_fecha_actual asc;', '3'),
	(18, 'SManager - Clientes DTE por Fecha de Actualización', 'select clientes.rut, clientes.fantasia, funcionarios.nombre as funcionario, clientes.dte_fecha_actual \r\nfrom clientes\r\ninner join funcionarios\r\non clientes.funcionario = funcionarios.id\r\nwhere dte = "1"\r\norder by dte_fecha_actual asc;', '3'),
	(19, 'SManager - Clientes con ASSM', 'select clientes.rut, clientes.fantasia, funcionarios.nombre as funcionario\n\nfrom clientes\n\ninner join funcionarios\non clientes.funcionario = funcionarios.id\n\nwhere assm = "1"\n\norder by clientes.fantasia;', '3'),
	(23, 'MySQL - Tamaño Base de datos', 'SELECT \ntable_schema "database", \nFORMAT (sum(data_length + index_length)/1024/1024, 2)  as "size in MB" \nFROM information_schema.TABLES \nGROUP BY table_schema\norder by sum(data_length + index_length)/1024/1024 desc;', '2'),
	(24, 'MySQL - Tamaño de la base de datos', 'SELECT \ntable_schema "database", \nFORMAT (sum(data_length + index_length)/1024/1024, 2)  as "size in MB" \nFROM information_schema.TABLES \nGROUP BY table_schema\norder by sum(data_length + index_length)/1024/1024 desc;', '1'),
	(25, 'DTE - Folios de Guías Repetidos', 'SELECT id, folio, tipo_doc, utilizado, sucursal_id\nFROM detalle_folios\nWHERE tipo_doc = 52 and folio\n    IN (\n    SELECT folio\n    FROM detalle_folios\n    GROUP BY folio\n    HAVING count( folio ) >1\n    )\nand utilizado = 0\nORDER BY folio;', '1'),
	(26, 'DTE - Folios Boletas Repetidos aunque estén usados', 'SELECT id, folio, tipo_doc, utilizado, sucursal_id\nFROM detalle_folios\nWHERE tipo_doc = 39 and folio\n    IN (\n    SELECT folio\n    FROM detalle_folios\n    GROUP BY folio\n    HAVING count( folio ) >1\n    )\nORDER BY folio;', '1');
/*!40000 ALTER TABLE `sql_queries` ENABLE KEYS */;

-- Volcando estructura para tabla smanager2.sucursales
CREATE TABLE IF NOT EXISTS `sucursales` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fk_cliente` char(10) DEFAULT NULL,
  `sucursal_correl` int NOT NULL,
  `sucursal_nombre` char(40) NOT NULL,
  `ip` char(50) NOT NULL,
  `ssh` char(1) NOT NULL,
  `root_access` char(1) NOT NULL,
  `root_user` char(50) DEFAULT NULL,
  `root_pass` char(50) DEFAULT NULL,
  `regular_user` char(50) DEFAULT NULL,
  `regular_pass` char(50) DEFAULT NULL,
  `puerto_ssh` char(8) DEFAULT NULL,
  `mysql` char(1) NOT NULL,
  `puerto_mysql` char(8) DEFAULT NULL,
  `root_user_mysql` char(50) DEFAULT NULL,
  `root_pass_mysql` char(50) DEFAULT NULL,
  `acceso_user_mysql` char(50) DEFAULT NULL,
  `acceso_pass_mysql` char(50) DEFAULT NULL,
  `dte_db_mysql` char(50) DEFAULT NULL,
  `erp_db_mysql` char(50) DEFAULT NULL,
  `gestor_dte` char(1) NOT NULL,
  `gestor_dte_user` char(50) DEFAULT NULL,
  `gestor_dte_pass` char(50) DEFAULT NULL,
  `play_path` char(50) DEFAULT NULL,
  `dte_path` char(50) DEFAULT NULL,
  `screen_id` char(50) DEFAULT NULL,
  `puerto_play` char(50) DEFAULT NULL,
  `seg_espera` char(10) DEFAULT NULL,
  `ticket` char(1) DEFAULT NULL,
  `ticket_url` char(50) DEFAULT NULL,
  `ticket_user` char(50) DEFAULT NULL,
  `ticket_pass` char(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_clientes` (`fk_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Volcando datos para la tabla smanager2.sucursales: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `sucursales` DISABLE KEYS */;
/*!40000 ALTER TABLE `sucursales` ENABLE KEYS */;

-- Volcando estructura para tabla smanager2.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` char(50) DEFAULT NULL,
  `password` varchar(90) DEFAULT NULL,
  `tipo_usuario` int DEFAULT NULL,
  `descripcion` char(50) DEFAULT NULL,
  `id_sucursal` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla smanager2.usuarios: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`id`, `nombre`, `password`, `tipo_usuario`, `descripcion`, `id_sucursal`) VALUES
	(1, 'Qn36Ewuyry0=', 'Qn36Ewuyry0=', 1, 'Eric Concha', NULL);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
