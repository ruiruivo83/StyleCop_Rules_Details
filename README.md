# StyleCop_Rules_Details
/*
 
According to the StyleCop Rules Documentation the ordering is as follows.

Within a class, struct or interface: (SA1201 and SA1203)

Constant Fields 
- Const keyword is used to declare constant fields and constant local. 
The value of the constant field is the same throughout the program or in other words, 
once the constant field is assigned the value of this field is not be changed. In C#, 
constant fields and locals are not variables, a constant is a number, string, null reference, 
boolean values.

Fields 
- A field is a variable of any type that is declared directly in a class or struct. 
Fields are members of their containing type.

Constructors 
- Whenever a class or struct is created, its constructor is called. 
A class or struct may have multiple constructors that take different arguments. 
Constructors enable the programmer to set default values, limit instantiation, 
and write code that is flexible and easy to read. For more information and examples, 
see Instance constructors and Using constructors.

Finalizers (Destructors)
- Finalizers (historically referred to as destructors) are used to perform any necessary 
final clean-up when a class instance is being collected by the garbage collector. 
In most cases, you can avoid writing a finalizer by using the System.Runtime.InteropServices. 
SafeHandle or derived classes to wrap any unmanaged handle.

Delegates
- A delegate is a type that represents references to methods with a particular parameter list and return type. 
When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. 
You can invoke (or call) the method through the delegate instance.

Events
- An event is a message sent by an object to signal the occurrence of an action.
The action can be caused by user interaction, such as a button click, 
or it can result from some other program logic, such as changing a property's value. 
The object that raises the event is called the event sender. 
The event sender doesn't know which object or method will receive (handle) the events it raises. 
The event is typically a member of the event sender; for example, the Click event is a member of the Button class, 
and the PropertyChanged event is a member of the class that implements the INotifyPropertyChanged interface.

Enums
- An enumeration type (or enum type) is a value type defined by a set of named constants of the underlying integral numeric type.

Interfaces (interface implementations)
- An interface defines a contract. Any class or struct that implements that contract must provide an implementation of the members defined in the interface.

Properties
- A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field. 
Properties can be used as if they are public data members, but they are actually special methods called accessors. 
This enables data to be accessed easily and still helps promote the safety and flexibility of methods.

Indexers
- Indexers allow instances of a class or struct to be indexed just like arrays. 
The indexed value can be set or retrieved without explicitly specifying a type or instance member. 
Indexers resemble properties except that their accessors take parameters.

Methods
- A method is a code block that contains a series of statements. 
A program causes the statements to be executed by calling the method and specifying any required method arguments. 
In C#, every executed instruction is performed in the context of a method.


Structs
- A structure type (or struct type) is a value type that can encapsulate data and related functionality. 
You use the struct keyword to define a structure type:

Classes 
- A type that is defined as a class is a reference type. At run time, 
when you declare a variable of a reference type, the variable contains the value null until you explicitly 
create an instance of the class by using the new operator, or assign it an object of a compatible type 
that may have been created elsewhere, as shown in the following

Within each of these groups order by access: (SA1202)

public
internal
protected internal
protected
private
Within each of the access groups, order by static, then non-static: (SA1204)

static
non-static
Within each of the static/non-static groups of fields, order by readonly, then non-readonly : (SA1214 and SA1215)

readonly
non-readonly
An unrolled list is 130 lines long, so I won't unroll it here. The methods part unrolled is:

public static methods
public methods
internal static methods
internal methods
protected internal static methods
protected internal methods
protected static methods
protected methods
private static methods
private methods
 
 */
