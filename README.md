# Homework5
5 Questions

1. Vehicles and Cars
Objective: Introduce students to inheritance, constructors, and overriding ToString().
Instructions:
1.	Create a base class called Vehicle with:
o	Properties for Make, Model, and Year, using get and set.
o	A constructor that initializes these properties.
o	An overridden ToString() method that returns a string in the format: "Year Make Model".
2.	Create two subclasses, Car and Motorcycle, that inherit from Vehicle.
o	Car should have an additional property NumberOfDoors.
o	Motorcycle should have an additional property HasSidecar.
o	Each subclass should have a constructor that calls base() to initialize Make, Model, and Year.
o	Override ToString() in each subclass so that Car returns "Year Make Model with X doors" and Motorcycle returns "Year Make Model (Has Sidecar: true/false)".

2. Employees and Specializations
Objective: Reinforce constructor chaining and overriding ToString().
Instructions:
1.	Create a base class called Employee with:
o	Properties for Name and Salary.
o	A constructor that initializes these properties.
o	An overridden ToString() method that returns "Employee: Name, Salary: $Salary".
2.	Create two subclasses, Manager and Engineer, that inherit from Employee.
o	Manager should have an additional property NumberOfEmployeesManaged.
o	Engineer should have an additional property Specialization.
o	Each subclass should have a constructor that calls base() to initialize Name and Salary.
o	Override ToString() so that Manager includes the number of employees managed, and Engineer includes the specialization.

3. Shapes and Areas
Objective: Teach students how to define and override methods in subclasses.
Instructions:
1.	Create an abstract base class called Shape with:
o	A Color property.
o	A constructor to initialize Color.
o	An abstract method GetArea(), which will be implemented by subclasses.
o	An overridden ToString() method that returns "Color Shape".
2.	Create two subclasses, Rectangle and Circle, that inherit from Shape.
o	Rectangle should have properties for Width and Height, and its GetArea() method should return Width * Height.
o	Circle should have a Radius property, and its GetArea() method should return Math.PI * Radius * Radius.
o	Each subclass should override ToString() to also include the shape’s dimensions and calculated area.

4. Animals and Sounds
Objective: Reinforce method overriding in subclasses.
Instructions:
1.	Create a base class called Animal with:
o	A Name property.
o	A constructor to initialize Name.
o	A virtual method MakeSound(), which returns "Some generic animal sound".
o	An overridden ToString() method that returns "Animal: Name, Sound: MakeSound()".

2.	Create two subclasses, Dog and Cat, that inherit from Animal.
o	Dog should override MakeSound() to return "Bark".
o	Cat should override MakeSound() to return "Meow".
o	Ensure that ToString() still correctly calls MakeSound() when printing the object.




5. Library System
Objective: Combine inheritance, encapsulation, and method overriding.
Instructions:
1.	Create a base class called Book with:
o	Properties for Title, Author, and YearPublished.
o	A constructor to initialize these properties.
o	An overridden ToString() method that returns "Title by Author (YearPublished)".

2.	Create two subclasses, EBook and PrintedBook, that inherit from Book.
o	EBook should have an additional property FileSizeMB.
o	PrintedBook should have an additional property PageCount.
o	Each subclass should override ToString() so that EBook includes the file size and PrintedBook includes the number of pages.
