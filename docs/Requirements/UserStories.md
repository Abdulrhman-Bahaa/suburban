## Actors Use Cases:

### Guest:

- Register
- Login
- Browse Games

### User:

- Login
- Browse Games
- View Game Details
- Add to Cart
- Checkout
- View Library
- Write Review
- Rate Game

### Admin:

- Login
- Manage Games (CRUD)
- Manage Users
- View Orders
- Moderate Reviews

---

## 2.2 Use Case Descriptions

### UC1: Browse Games

- Actor: Guest/User
- Description: View list of available games
- Precondition: None
- Postcondition: Games displayed

### UC2: Add to Cart

- Actor: User
- Precondition: User logged in
- Postcondition: Game added to cart

### UC3: Checkout

- Actor: User
- Precondition: Cart not empty
- Postcondition: Order created, games added to library

### UC4: Manage Games

- Actor: Admin
- Precondition: Admin logged in
- Postcondition: Game data updated

---

## 2.3 User Stories

### Game Store Browsing

- As a user, I want to browse games so that I can discover new titles
- As a user, I want to filter games so I can find specific genres
- As a user, I want to view game details so I can decide to buy

### Purchase System

- As a user, I want to add games to a cart so I can buy multiple games
- As a user, I want to checkout so I can purchase selected games
- As a user, I want to see purchase history so I can track my orders

### Game Library

- As a user, I want to access my purchased games so I can play them anytime

### Admin Control

- As an admin, I want to add games so I can expand the store
- As an admin, I want to manage users so I can control access
- As an admin, I want to view orders so I can track sales
