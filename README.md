```
CREATE TABLE products (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    category VARCHAR(50) NOT NULL,
    price NUMERIC(10,2) NOT NULL CHECK (price >= 0),
    stock_quantity INTEGER NOT NULL CHECK (stock_quantity >= 0),
    supplier VARCHAR(100),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
```

```
INSERT INTO products (name, category, price, stock_quantity, supplier) VALUES
('Laptop Lenovo ThinkPad', 'Electronics', 1200.00, 15, 'TechSupplier Ltd'),
('iPhone 14', 'Electronics', 999.99, 25, 'Apple Distributor'),
('Samsung TV 55"', 'Electronics', 650.50, 10, 'Samsung Supplier'),
('Office Chair', 'Furniture', 150.00, 40, 'Furniture Co'),
('Wooden Desk', 'Furniture', 320.00, 20, 'Furniture Co'),
('Coffee Maker', 'Home Appliances', 85.75, 35, 'HomeTech'),
('Blender Philips', 'Home Appliances', 60.00, 50, 'Philips Official'),
('Running Shoes Nike', 'Sportswear', 120.00, 60, 'Nike Distributor'),
('T-shirt Adidas', 'Sportswear', 35.00, 100, 'Adidas Official'),
('Backpack Travel Pro', 'Accessories', 75.50, 45, 'Travel Gear'),
('Gaming Mouse Logitech', 'Electronics', 45.99, 80, 'Logitech Supplier'),
('Keyboard Mechanical', 'Electronics', 110.00, 30, 'KeyTech'),
('Water Bottle 1L', 'Accessories', 15.00, 150, 'Outdoor Supply'),
('Smart Watch', 'Electronics', 199.99, 22, 'Gadget World'),
('Tablet Samsung', 'Electronics', 450.00, 18, 'Samsung Supplier'),
('Desk Lamp LED', 'Furniture', 40.00, 70, 'LightHouse'),
('Refrigerator LG', 'Home Appliances', 800.00, 8, 'LG Supplier'),
('Microwave Oven', 'Home Appliances', 120.00, 25, 'HomeTech'),
('Yoga Mat', 'Sportswear', 25.00, 90, 'Fitness Store'),
('Electric Kettle', 'Home Appliances', 55.00, 60, 'Kitchen Goods');

```
