﻿object height = 1.88; // Storing a double in an object
object name = "Amir"; // Storing a string in an object
Console.WriteLine($"{name} is {height} meters tall.");

// int length1 = name.Length; // This gives a compile error.
int length2 = ((string)name).Length; // Cast name to a string.
Console.WriteLine($"{name} has {length2} characters.");

dynamic something;

// Storing an array of int values in a dynamic object.
// An aarray of any type has a Length property.
something = new [] { 3, 5, 7 };

// Storing an int in a dynamic object.
// int does not have a Length property.
// something = 12;

// Storing a string in a dynamic object.
// A string has a Length property.
// something = "Ahmed";

// This compiles but throws an exception at runtime.
Console.WriteLine($"The length of something is {something.Length}.");

// Output the type of the something variable.
Console.WriteLine($"something is a {something.GetType()}.");