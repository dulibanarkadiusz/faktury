-- phpMyAdmin SQL Dump
-- version 3.5.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Czas wygenerowania: 21 Cze 2016, 13:11
-- Wersja serwera: 5.5.21-log
-- Wersja PHP: 5.4.10

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Baza danych: `faktury`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `artykul`
--

CREATE TABLE IF NOT EXISTS `artykul` (
  `kod` varchar(13) COLLATE utf8_unicode_ci NOT NULL,
  `cena_netto` decimal(10,2) unsigned NOT NULL,
  `jednostkaM` enum('usluga','sztuka','opakowanie','m2','kg','litr','m') COLLATE utf8_unicode_ci NOT NULL,
  `stawka_VAT` decimal(10,2) NOT NULL,
  `nazwa` varchar(80) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`kod`),
  UNIQUE KEY `kod` (`kod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Zrzut danych tabeli `artykul`
--

INSERT INTO `artykul` (`kod`, `cena_netto`, `jednostkaM`, `stawka_VAT`, `nazwa`) VALUES
('001', 100.00, 'usluga', 23.00, 'Smocze jagody'),
('0011', 94.00, 'usluga', 23.00, 'asd');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `faktura`
--

CREATE TABLE IF NOT EXISTS `faktura` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numer` char(13) COLLATE utf8_unicode_ci DEFAULT NULL,
  `id_kontrahenta` int(10) unsigned NOT NULL,
  `id_pracownika` int(10) unsigned NOT NULL,
  `data_wystawienia` date NOT NULL,
  `termin_platnosci` date NOT NULL,
  `data_sprzedazy` date NOT NULL,
  `forma_platnosci` enum('przelew','gotówka','karta płatnicza','płatność online','płatność ratalna') COLLATE utf8_unicode_ci NOT NULL,
  `zaplacona_kwota` decimal(10,2) unsigned NOT NULL,
  `nr_konta_bankowego` varchar(28) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `numer` (`numer`),
  KEY `id_kontrahenta` (`id_kontrahenta`),
  KEY `id_pracownika` (`id_pracownika`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=35 ;

--
-- Zrzut danych tabeli `faktura`
--

INSERT INTO `faktura` (`id`, `numer`, `id_kontrahenta`, `id_pracownika`, `data_wystawienia`, `termin_platnosci`, `data_sprzedazy`, `forma_platnosci`, `zaplacona_kwota`, `nr_konta_bankowego`) VALUES
(1, '1/05/2016', 1, 2, '2016-05-13', '2016-05-27', '2016-05-15', 'gotówka', 0.00, NULL),
(2, '2/05/2016', 2, 1, '2016-05-13', '2016-05-20', '2016-05-15', 'przelew', 100.00, NULL),
(3, '12/05/2016', 1, 1, '2016-05-13', '2016-05-13', '2016-05-15', 'gotówka', 1.00, NULL),
(4, '100/05/2016', 2, 1, '2016-05-13', '2016-05-13', '2016-05-15', 'karta płatnicza', 5.00, NULL),
(9, '101/05/2016', 1, 1, '2016-05-11', '2016-05-27', '2016-05-15', 'przelew', 0.00, NULL),
(10, '102/05/2016', 1, 1, '2016-05-11', '2016-05-27', '2016-05-15', 'przelew', 0.00, NULL),
(11, '103/05/2016', 1, 1, '2016-05-11', '2016-05-27', '2016-05-15', 'przelew', 0.00, NULL),
(12, '104/05/2016', 1, 1, '2016-05-11', '2016-05-20', '2016-05-15', '', 0.00, NULL),
(13, '105/05/2016', 1, 1, '2016-05-11', '2016-05-20', '2016-05-15', 'gotówka', 0.00, NULL),
(14, '106/05/2016', 1, 1, '2016-05-11', '2016-05-20', '2016-05-15', '', 0.00, NULL),
(16, '108/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(17, '109/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(18, '110/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(19, '111/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(20, '112/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(21, '113/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(22, '114/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(23, '115/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(24, '116/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(25, '117/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(26, '118/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(27, '119/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(28, '120/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(29, '121/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(30, '122/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(31, '123/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'przelew', 0.00, NULL),
(32, '124/05/2016', 1, 1, '2016-05-11', '2016-05-29', '2016-05-15', 'karta płatnicza', 100.93, NULL),
(33, '125/05/2016', 1, 1, '2016-05-04', '2016-05-29', '2016-05-15', 'gotówka', 0.00, NULL),
(34, '126/05/2016', 1, 1, '2016-05-29', '2016-06-12', '2016-05-29', 'karta płatnicza', 0.00, NULL);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `kontrahent`
--

CREATE TABLE IF NOT EXISTS `kontrahent` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ulica` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `miasto` char(32) COLLATE utf8_unicode_ci NOT NULL,
  `kod_pocztowy` int(5) unsigned NOT NULL,
  `email` char(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NIP` int(10) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nazwa` (`nazwa`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=6 ;

--
-- Zrzut danych tabeli `kontrahent`
--

INSERT INTO `kontrahent` (`id`, `nazwa`, `imie_nazwisko`, `ulica`, `miasto`, `kod_pocztowy`, `email`, `NIP`) VALUES
(1, 'Fakturzyści sp. z o.o.', '', 'Kaszubska 23', 'Gliwice', 44122, 'arkadul804@student.polsl.pl', NULL),
(2, 'Arkadiusz Duliban', '', 'Kłodnicka 1/0', 'Gliwice', 44100, 'arkadiusz.duliban@gmail.com', NULL),
(3, '', '', 'ulica 9/2', 'zabrze', 11811, 'aaa@wp.pl', 990),
(4, 'jkkj', 'jkkj', 'hhh', '11222', 0, '1111', 0),
(5, 'hhhh', 'hhhh', 'hhhh', '77777', 0, '777', 0);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pozycja_faktury`
--

CREATE TABLE IF NOT EXISTS `pozycja_faktury` (
  `id_pozycji` int(11) NOT NULL AUTO_INCREMENT,
  `kod_artykulu` varchar(13) COLLATE utf8_unicode_ci NOT NULL,
  `nr_faktury` char(13) COLLATE utf8_unicode_ci NOT NULL,
  `ilosc` int(10) unsigned NOT NULL,
  `rabat` decimal(10,2) NOT NULL,
  `cena` decimal(10,2) unsigned NOT NULL,
  PRIMARY KEY (`id_pozycji`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=9 ;

--
-- Zrzut danych tabeli `pozycja_faktury`
--

INSERT INTO `pozycja_faktury` (`id_pozycji`, `kod_artykulu`, `nr_faktury`, `ilosc`, `rabat`, `cena`) VALUES
(3, '001', '1/05/2016', 100, 0.00, 9.99),
(4, '002', '1/05/2016', 10, 0.00, 19.99),
(5, '1', '1', 1, 1.00, 1.00),
(6, '1', '124/05/2016', 6, 0.00, 100.00),
(7, '1', '125/05/2016', 100, 0.00, 100.00),
(8, '2', '125/05/2016', 20, 0.00, 44.00);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pracownik`
--

CREATE TABLE IF NOT EXISTS `pracownik` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `mysql_login` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `imie` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `nazwisko` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;

--
-- Zrzut danych tabeli `pracownik`
--

INSERT INTO `pracownik` (`ID`, `mysql_login`, `imie`, `nazwisko`) VALUES
(1, 'root', 'Mirosław', 'Poważny'),
(2, 'asd', 'Administrator', 'Systemu');

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `faktura`
--
ALTER TABLE `faktura`
  ADD CONSTRAINT `faktura_ibfk_1` FOREIGN KEY (`id_kontrahenta`) REFERENCES `kontrahent` (`id`),
  ADD CONSTRAINT `faktura_ibfk_2` FOREIGN KEY (`id_pracownika`) REFERENCES `pracownik` (`ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
