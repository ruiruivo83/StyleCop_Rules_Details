/*
 
According to the StyleCop Rules Documentation the ordering is as follows.

Within a class, struct or interface: (SA1201 and SA1203)

Constant Fields - Const keyword is used to declare constant fields and constant local. 
The value of the constant field is the same throughout the program or in other words, 
once the constant field is assigned the value of this field is not be changed. In C#, 
constant fields and locals are not variables, a constant is a number, string, null reference, 
boolean values.

Fields - A field is a variable of any type that is declared directly in a class or struct. 
Fields are members of their containing type.

Constructors - Whenever a class or struct is created, its constructor is called. 
A class or struct may have multiple constructors that take different arguments. 
Constructors enable the programmer to set default values, limit instantiation, 
and write code that is flexible and easy to read. For more information and examples, 
see Instance constructors and Using constructors.

Finalizers (Destructors)
Delegates
Events
Enums
Interfaces (interface implementations)
Properties
Indexers
Methods
Structs
Classes
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
