Product Management Tool

📦 **Description**  
This is an internal tool for managing the product catalog of an eCommerce platform.  
It allows internal users (merchandisers, category managers) to:

- Define new product categories
- Create custom attributes per category
- Manage products with category-specific attributes
- Maintain data integrity and support future scalability

The platform currently sells dresses and shoes, with plans to expand into new categories.

---

## **Tech Stack**

- **Backend:** ASP.NET Core MVC, C#  
- **Frontend:** Razor Views, Bootstrap 5  
- **Database:** SQL Server  
- **ORM / Mapping:** Entity Framework Core, AutoMapper  

---

## **Database Schema**

The system has the following main tables:

- `Categories` – stores product categories  
- `Attributes` – stores attribute names  
- `CategoryAttributes` – maps categories to attributes and stores their data type  
- `Products` – stores products with category references  
- `ProductAttributeValues` – stores product-specific attribute values  

All foreign key relationships enforce data integrity.

---

## **Features**

### Categories
- Add new categories
- Delete categories
- View all categories

### Attributes
- Add new attributes
- Delete attributes
- View all attributes

### Category-Attribute Mapping
- Map attributes to categories
- Specify the data type of each attribute

### Products
- Add new products
- Delete products
- View all products

### Product Attribute Values
- Assign attribute values to products
- View all product attribute values

---

## **Setup Instructions**

1. **Clone the repository:**
   ```bash
   git clone https://github.com/rohanpatil6/ProductManagementTool.git
   cd ProductManagementTool
