
DROP TABLE IF EXISTS `store`;
CREATE TABLE `store` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

BEGIN;
INSERT INTO `store` (`id`, `name`) VALUES (1, 'test store 1');
INSERT INTO `store` (`id`, `name`) VALUES (2, 'test store 2');
INSERT INTO `store` (`id`, `name`) VALUES (3, 'test store 3');
COMMIT;
