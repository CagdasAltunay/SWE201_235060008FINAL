Project Overview

This project is a Library Management System developed in C# as part of the SWE201 course. The main goal of the project is to demonstrate Object-Oriented Programming (OOP) concepts such as class design, encapsulation, and interactions between objects.

The README focuses on:

What the application is intended to do in a full-scale implementation

What the application actually does in the submitted testing model

Intended Full-Scale Functionality

In a full-scale version, this project aims to simulate a real-world library system where:

Books can be added, updated, searched, borrowed, and returned

Library members can be registered and managed

Book availability is tracked dynamically

The system provides reports and statistics about books and members

A graphical or web-based user interface and a database could be integrated

This design allows the system to be expanded easily without changing the core class structure.

Submitted Version – Testing Model

The submitted version is a console-based application designed as a simplified model to demonstrate class interactions and OOP principles rather than a complete library system.

The focus of this version is on how the classes work together.

Class Design and Responsibilities
📘 Book Class

The Book class represents a single book in the library.

Responsibilities:

Stores book-related data such as title, author, ISBN, and availability status

Keeps track of whether the book is currently borrowed or available

Acts as a basic data model for library items

This class demonstrates encapsulation by keeping book properties within a single object.

👤 Member Class

The Member class represents a library user.

Responsibilities:

Stores member information (such as name or ID)

Represents the person who can borrow books

Acts as an entity that interacts with books through the library system

This class models real-world users and allows the system to associate actions (borrowing books) with members.

🏛️ Library Class

The Library class is the core controller of the application.

Responsibilities:

Stores collections of Book and Member objects

Manages borrowing and returning operations

Controls interactions between members and books

Ensures that books can only be borrowed if they are available

This class demonstrates:

Object interaction

Separation of responsibilities

Centralized management of system logic

▶️ Program Class

The Program class serves as the entry point of the application.

Responsibilities:

Creates sample Book and Member objects

Calls methods from the Library class to test functionality

Demonstrates how the classes work together in a simple scenario

How the Classes Work Together

Program creates instances of Book and Member

These objects are passed to the Library

The Library manages borrowing and returning operations

Book availability changes based on library actions

All interactions are handled through well-defined class methods

This structure makes the project easy to extend and maintain.
