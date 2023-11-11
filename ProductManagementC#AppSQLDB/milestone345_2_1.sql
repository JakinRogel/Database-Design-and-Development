-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3307
-- Generation Time: Nov 11, 2023 at 12:30 AM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `milestone345_2.1`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `phone` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `address` varchar(50) NOT NULL,
  `city` varchar(50) NOT NULL,
  `state` varchar(2) NOT NULL,
  `post_code` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `first_name`, `last_name`, `phone`, `email`, `address`, `city`, `state`, `post_code`) VALUES
(1, 'Aland', 'Hartridge', '862-309-8207', 'ahartridge0@amazonaws.com', 'Apt 599', 'Newark', 'NJ', '07188'),
(2, 'Sibylla', 'Macias', '405-406-8502', 'smacias1@senate.gov', 'Room 1020', 'Oklahoma City', 'OK', '73173'),
(3, 'Alasdair', 'Drillingcourt', '571-399-2775', 'adrillingcourt2@feedburner.com', 'Apt 823', 'Reston', 'VA', '22096'),
(4, 'Daryl', 'Gorcke', '718-285-6303', 'dgorcke3@nsw.gov.au', 'Room 1556', 'Staten Island', 'NY', '10305'),
(5, 'Kristopher', 'Kimbrey', '949-249-3144', 'kkimbrey4@mapquest.com', 'PO Box 44759', 'Orange', 'CA', '92867'),
(6, 'Quinn', 'Trask', '501-493-7964', 'qtrask5@samsung.com', 'Room 1416', 'Hot Springs National Park', 'AR', '71914'),
(7, 'Blanch', 'Oldroyde', '937-142-6972', 'boldroyde6@cargocollective.com', 'PO Box 90325', 'Dayton', 'OH', '45490'),
(8, 'Brenda', 'Peiro', '609-762-1553', 'bpeiro7@github.io', 'Suite 74', 'Trenton', 'NJ', '08603'),
(9, 'Giustina', 'Jaggs', '720-172-9283', 'gjaggs8@bloglines.com', '9th Floor', 'Denver', 'CO', '80299'),
(10, 'Gearalt', 'Watt', '267-330-8095', 'gwatt9@senate.gov', '5th Floor', 'Philadelphia', 'PA', '19146');

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `Employee_id` int(11) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `EmployeePhone` varchar(100) NOT NULL,
  `ActivelyEmployed` int(11) NOT NULL,
  `StoreName` varchar(100) NOT NULL,
  `stores_StoreIdNumber` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`Employee_id`, `FirstName`, `LastName`, `EmployeePhone`, `ActivelyEmployed`, `StoreName`, `stores_StoreIdNumber`) VALUES
(1, 'Auberon', 'Oppy', '720-227-4768', 1, 'Wolff-Rohan', 4),
(2, 'Bevon', 'Beebis', '153-620-6862', 1, 'Jones-Stanton', 9),
(3, 'Hurley', 'Sinyard', '368-403-8590', 1, 'Luettgen LLC', 7),
(4, 'Bird', 'Di Iorio', '641-281-4604', 0, 'Hintz Inc', 2),
(5, 'Wesley', 'Crandon', '937-591-0010', 0, 'Wolff-Rohan', 4),
(6, 'Buddy', 'Broxton', '201-347-7305', 1, 'Jones-Stanton', 9),
(7, 'Carl', 'Guerrier', '714-515-5120', 0, 'Luettgen LLC', 7),
(8, 'Veda', 'Beake', '324-276-8773', 0, 'Hintz Inc', 2),
(9, 'Sonja', 'Vile', '695-907-2758', 1, 'Wolff-Rohan', 4),
(10, 'Melesa', 'Hamflett', '694-343-1156', 1, 'Jones-Stanton', 9);

-- --------------------------------------------------------

--
-- Table structure for table `orderitem`
--

CREATE TABLE `orderitem` (
  `OrderItemId` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `products_ProductId` int(11) NOT NULL,
  `orders_OrderId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `OrderId` int(11) NOT NULL,
  `OrderDate` date NOT NULL,
  `ShippedDate` date NOT NULL,
  `SpecialInstructions` varchar(400) NOT NULL,
  `customers_customer_id` int(11) NOT NULL,
  `stores_StoreIdNumber` int(11) NOT NULL,
  `employees_Employee_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`OrderId`, `OrderDate`, `ShippedDate`, `SpecialInstructions`, `customers_customer_id`, `stores_StoreIdNumber`, `employees_Employee_id`) VALUES
(1, '2023-10-06', '2023-03-30', 'Email customer upon delivery', 9, 4, 1),
(2, '2022-12-10', '2023-10-13', 'Call customer upon deliver', 4, 9, 6),
(3, '2023-03-07', '2023-03-30', 'Email customer upon delivery', 2, 7, 7),
(4, '2023-01-28', '2022-12-25', 'Email customer upon delivery', 8, 2, 4),
(5, '2023-01-10', '2023-02-23', 'Call customer upon deliver', 5, 4, 1),
(6, '2022-11-21', '2022-12-27', 'Deliver to the customer', 3, 9, 6),
(7, '2023-06-18', '2023-10-09', 'Leave at the door', 7, 7, 7),
(8, '2022-10-25', '2023-01-12', 'Call customer upon deliver', 1, 2, 4),
(9, '2023-03-22', '2023-03-06', 'Leave at the door', 10, 4, 1),
(10, '2022-11-02', '2023-09-20', 'Leave at the door', 6, 9, 6);

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `PaymentId` int(11) NOT NULL,
  `Amount` double NOT NULL,
  `Date` date NOT NULL,
  `OrdersId` int(11) NOT NULL,
  `customers_customer_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`PaymentId`, `Amount`, `Date`, `OrdersId`, `customers_customer_id`) VALUES
(11, 83.56, '2023-10-05', 1, 9),
(12, 69.45, '2023-08-07', 2, 4),
(13, 6.11, '2023-05-15', 3, 2),
(14, 44.58, '2023-05-22', 4, 8),
(15, 52.79, '2023-01-18', 5, 5),
(16, 80.84, '2023-01-12', 6, 3),
(17, 34.05, '2023-01-31', 7, 7),
(18, 90.37, '2023-04-05', 8, 1),
(19, 19.45, '2023-04-05', 9, 10),
(20, 18.81, '2023-08-07', 10, 6);

-- --------------------------------------------------------

--
-- Table structure for table `productcategories`
--

CREATE TABLE `productcategories` (
  `CategoryId` int(11) NOT NULL,
  `CategoryName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `productcategories`
--

INSERT INTO `productcategories` (`CategoryId`, `CategoryName`) VALUES
(1, 'Landscaping & Irrigation'),
(3, 'Fire Sprinkler System'),
(4, 'Construction Clean and Final Clean'),
(5, 'Site Furnishings'),
(6, 'Painting & Vinyl Wall Covering'),
(7, 'Fire Protection'),
(8, 'Plumbing & Medical Gas'),
(9, 'Furniture '),
(10, 'Doors, Frames & Hardware'),
(13, 'test');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ProductId` int(11) NOT NULL,
  `ProductName` varchar(50) NOT NULL,
  `ProductDescription` varchar(400) NOT NULL,
  `RetailPrice` double NOT NULL,
  `WholesalePrice` double NOT NULL,
  `CategoryId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`ProductId`, `ProductName`, `ProductDescription`, `RetailPrice`, `WholesalePrice`, `CategoryId`) VALUES
(3, 'Fire Sprinkler', 'Directs water to everything, but hopefully it gets the stuff that\'s too hot as well', 78, 34, 3),
(4, 'Bleach', 'The enemy of everything dirty', 68, 32, 4),
(5, 'Ladder', 'To reach those hard to reach places (requires a lack of fear of heights)', 115, 75, 5),
(6, 'Beige Paint 64oz ', 'If you want your walls to look like flesh', 45, 23, 6),
(7, 'Fire Proof Jacket', 'For those unfortunate encounters that get a little too hot', 478, 400, 7),
(8, 'Laughing Gas 150oz', 'Feeling down? Not anymore! You also may wake up missing a non-vital body part', 875, 743, 8),
(9, 'Steel Frame Chair', 'Surprisingly uncomfortable. You would think this wouldn\'t be a thing for how heavy they are and hard.', 145, 103, 9),
(10, 'Elevator Door', 'Those huge doors that you fear will crush you if you take too long. ', 976, 870, 10);

-- --------------------------------------------------------

--
-- Table structure for table `stores`
--

CREATE TABLE `stores` (
  `StoreIdNumber` int(11) NOT NULL,
  `StoreName` varchar(400) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `stores`
--

INSERT INTO `stores` (`StoreIdNumber`, `StoreName`) VALUES
(1, 'Gleason, Bartoletti and Halvorson'),
(2, 'Hintz Inc'),
(3, 'Moen, Schaden and Sanford'),
(4, 'Wolff-Rohan'),
(5, 'Collier, Bartell and Carroll'),
(6, 'Daugherty, Feeney and Olson'),
(7, 'Luettgen LLC'),
(8, 'Pfannerstill-Kunde'),
(9, 'Jones-Stanton'),
(10, 'Schmitt Group');

-- --------------------------------------------------------

--
-- Table structure for table `vendors`
--

CREATE TABLE `vendors` (
  `VendorId` int(11) NOT NULL,
  `VendorName` varchar(400) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `vendors`
--

INSERT INTO `vendors` (`VendorId`, `VendorName`) VALUES
(1, 'Elevator'),
(2, 'Wall Protection'),
(3, 'Rebar & Wire Mesh Install'),
(4, 'Structural and Misc Steel (Fabrication)'),
(5, 'Sitework & Site Utilities'),
(6, 'Exterior Signage'),
(7, 'Curb & Gutter'),
(8, 'Drywall & Acoustical (FED)'),
(9, 'Framing (Wood)'),
(10, 'EIFS');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`Employee_id`,`stores_StoreIdNumber`),
  ADD KEY `fk_employees_stores1_idx` (`stores_StoreIdNumber`);

--
-- Indexes for table `orderitem`
--
ALTER TABLE `orderitem`
  ADD PRIMARY KEY (`OrderItemId`,`products_ProductId`,`orders_OrderId`),
  ADD KEY `fk_orderitem_products1_idx` (`products_ProductId`),
  ADD KEY `fk_orderitem_orders1_idx` (`orders_OrderId`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderId`,`customers_customer_id`,`stores_StoreIdNumber`,`employees_Employee_id`),
  ADD KEY `fk_orders_customers1_idx` (`customers_customer_id`),
  ADD KEY `fk_orders_stores1_idx` (`stores_StoreIdNumber`),
  ADD KEY `fk_orders_employees1_idx` (`employees_Employee_id`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`PaymentId`,`customers_customer_id`),
  ADD KEY `fk_payments_customers_idx` (`customers_customer_id`);

--
-- Indexes for table `productcategories`
--
ALTER TABLE `productcategories`
  ADD PRIMARY KEY (`CategoryId`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ProductId`) USING BTREE,
  ADD KEY `fk_products_productcategories1_idx` (`CategoryId`);

--
-- Indexes for table `stores`
--
ALTER TABLE `stores`
  ADD PRIMARY KEY (`StoreIdNumber`);

--
-- Indexes for table `vendors`
--
ALTER TABLE `vendors`
  ADD PRIMARY KEY (`VendorId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `Employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `orderitem`
--
ALTER TABLE `orderitem`
  MODIFY `OrderItemId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `OrderId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `PaymentId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `productcategories`
--
ALTER TABLE `productcategories`
  MODIFY `CategoryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ProductId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `stores`
--
ALTER TABLE `stores`
  MODIFY `StoreIdNumber` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `vendors`
--
ALTER TABLE `vendors`
  MODIFY `VendorId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `employees`
--
ALTER TABLE `employees`
  ADD CONSTRAINT `fk_employees_stores1` FOREIGN KEY (`stores_StoreIdNumber`) REFERENCES `stores` (`StoreIdNumber`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `orderitem`
--
ALTER TABLE `orderitem`
  ADD CONSTRAINT `fk_orderitem_orders1` FOREIGN KEY (`orders_OrderId`) REFERENCES `orders` (`OrderId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orderitem_products1` FOREIGN KEY (`products_ProductId`) REFERENCES `products` (`ProductId`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `fk_orders_customers1` FOREIGN KEY (`customers_customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orders_employees1` FOREIGN KEY (`employees_Employee_id`) REFERENCES `employees` (`Employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orders_stores1` FOREIGN KEY (`stores_StoreIdNumber`) REFERENCES `stores` (`StoreIdNumber`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `payments`
--
ALTER TABLE `payments`
  ADD CONSTRAINT `fk_payments_customers` FOREIGN KEY (`customers_customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `fk_products_productcategories1` FOREIGN KEY (`CategoryId`) REFERENCES `productcategories` (`CategoryId`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
