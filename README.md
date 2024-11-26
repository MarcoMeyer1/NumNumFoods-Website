# Num Num Baby Foods E-Commerce WebApp

Welcome to the **Num Num Baby Foods E-Commerce WebApp**! This project was developed to provide a seamless and efficient platform for purchasing affordable and nutritious baby food, catering to the needs of busy parents.

## Features

### Customer-Facing Features
- **Homepage**: Highlights featured products and ongoing promotions.
- **Product Browsing**: Browse products by categories for different developmental stages.
- **Cart and Checkout**: Easy product addition, voucher application, and streamlined checkout process.
- **Profile Management**: Customers can manage personal information, view order history, and track order statuses.

### Admin Features
- **Admin Dashboard**: Centralized hub for managing:
  - Vouchers
  - Products
  - Orders
  - Stock
  - Events
  - Branches
- **Order Management**: Monitor and update order statuses.
- **Product Management**: Add, edit, and delete products; manage categories and stock levels.
- **Event Management**: Create and manage promotional events.

## Technology Stack

### Frontend
- Blazor WebAssembly: Enables a Progressive Web App (PWA) experience with offline capabilities and cross-platform support.

### Backend
- .NET Core API: Provides secure and scalable endpoints for:
  - Managing products, orders, and stock.
  - Admin functionalities like voucher and event management.

### Database
- Azure SQL Database: Stores structured data for products, customers, orders, and vouchers.

### Storage
- Azure Blob Storage: Efficiently manages product images and other media.

## Deployment and DevOps

- Hosting: The web app and API are hosted on Azure App Service for high availability and scalability.
- CI/CD Pipeline: Automated deployments are managed using GitHub Actions, ensuring smooth and reliable updates upon merging to the main branch.
