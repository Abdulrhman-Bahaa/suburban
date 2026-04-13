## 1.1 Introduction

### 1.1.1 Purpose

This document defines the functional and non-functional requirements for an Online Game Store system that allows users to browse, purchase, and manage digital games.

### 1.1.2 Scope

The system provides:

- Game catalog browsing
- User authentication and profiles
- Shopping cart and checkout
- Digital game library
- Admin management dashboard

### 1.1.3 Assumptions

- Payment is simulated (no real gateway required)
- Digital delivery is instant after purchase

---

## 1.2 Functional Requirements

### FR1: User Authentication

- Users can register, login, logout
- System shall validate credentials
- System shall support role-based access

### FR2: Game Management

- System shall display list of games
- System shall show game details
- System shall allow search and filtering

### FR3: Cart Management

- User can add/remove games from cart
- System calculates total price

### FR4: Order Processing

- System shall allow checkout
- System shall create order record
- System shall store purchase history

### FR5: Game Library

- User can view owned games
- User can access/download purchased games

### FR6: Reviews

- User can rate games (1–5)
- User can write reviews

### FR7: Admin Functions

- Admin can add/edit/delete games
- Admin can manage users
- Admin can view orders

---

## 1.3 Non-Functional Requirements

### NFR1: Security

- JWT authentication
- Role-based authorization
- Input validation

### NFR2: Performance

- API response time < 300ms for common queries
- Pagination for large datasets

### NFR3: Reliability

- Centralized error handling
- Logging system

---

## 1.4 System Constraints

- Built using ASP.NET Core
- PostgreSQL database
- No real payment gateway required
