# Guido's Gorgeous Lasagna

## Introduction

Python is a **[dynamic and strongly](https://stackoverflow.com/questions/11328920/is-python-strongly-typed)** typed programming language. It employs both **[duck typing](https://en.wikipedia.org/wiki/Duck_typing)** and **[gradual typing](https://en.wikipedia.org/wiki/Gradual_typing)** via **[type hints](https://docs.python.org/3/library/typing.html)**.

While Python supports many different programming styles, internally **everything in Python is an** **[object](https://docs.python.org/3/reference/datamodel.html)**. This includes numbers, strings, lists, and even functions.

We'll dig more into what all of that means as we continue through the track.

This first exercise introduces 4 major Python language features:

1. Name Assignment (variables and constants),
2. Functions (*the `def` keyword and the `return` keyword*),
3. Comments, and
4. Docstrings.

| Note                                                                                                                                                                                                                                           |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| In general, content, tests, and analyzer tooling for the Python track follow the style conventions outlined in PEP 8 and PEP 257 for Python code style, with the additional (strong) suggestion that there be no single letter variable names. |

On the Python track, variables are always written in snake_case, and constants in SCREAMING_SNAKE_CASE.

## Name Assignment (Variables & Constants)

Programmers can bind names (also called variables) to any type of object using the assignment = operator: `<name> = <value>.` A name can be reassigned (or re-bound) to different values (different object types) over its lifetime.

```py
> > > my_first_variable = 1 # my_first_variable bound to an integer object of value one.
> > > my_first_variable = 2 # my_first_variable re-assigned to integer value 2.

> > > print(type(my_first_variable))
> > > <class 'int'>

> > > print(my_first_variable)
> > > 2

> > > my_first_variable = "Now, I'm a string." # You may re-bind a name to a different object type and value.
> > > print(type(my_first_variable))
> > > <class 'str'>

> > > print(my_first_variable)
> > > "Now, I'm a string." # Strings can be declared using single or double quote marks.
```

### Constants

Constants are names meant to be assigned only once in a program. They should be defined at a module (file) level, and are typically visible to all functions and classes in the program. Using SCREAMING_SNAKE_CASE signals that the name should not be re-assigned, or its value mutated.

### Functions

The def keyword begins a function definition. Each function can have zero or more formal parameters in () parenthesis, followed by a : colon. Statements for the body of the function begin on the line following def and must be indented in a block.

```py
# The body of a function is indented by 2 spaces, & prints the sum of the numbers.

def add_two_numbers(number_one, number_two):
total = number_one + number_two
print(total)

> > > add_two_numbers(3, 4)
> > > 7

# Inconsistent indentation in your code blocks will raise an error.

> > > def add_three_numbers_misformatted(number_one, number_two, number_three):
... result = number_one + number_two + number_three # This was indented by 4 spaces.
... print(result) #this was only indented by 3 spaces
...
...
 File "<stdin>", line 3
    print(result)
    ^
IndentationError: unindent does not match any outer indentation level
```

Functions explicitly return a value or object via the return keyword. Functions that do not have an explicit return expression will implicitly return None.

```py
# Function definition on first line.

def add_two_numbers(number_one, number_two):
result = number_one + number_two
return result # Returns the sum of the numbers.

> > > add_two_numbers(3, 4)
> > > 7

# This function will return None.

def add_two_numbers(number_one, number_two):
result = number_one + number_two

> > > print(add_two_numbers(5, 7))
> > > None
```

### Calling Functions

Functions are called or invoked using their name followed by (). Dot (.) notation is used for calling functions defined inside a class or module.

```py
> > > def number_to_the_power_of(number_one, number_two):
        return number_one ** number_two
...

> > > number_to_the_power_of(3,3) # Invoking the function with the arguments 3 and 3.
> > > 27

# A mis-match between the number of parameters and the number of arguments will raise an error.

> > > number_to_the_power_of(4,)
> > > ...
> > > Traceback (most recent call last):
> > > File "<stdin>", line 1, in <module>
> > > TypeError: number_to_the_power_of() missing 1 required positional argument: 'number_two'

# Calling methods or functions in classes and modules.

> > > start_text = "my silly sentence for examples."
> > > str.upper(start_text) # Calling the upper() method for the built-in str class.
> > > "MY SILLY SENTENCE FOR EXAMPLES."

# Importing the math module

import math

> > > math.pow(2,4) # Calling the pow() function from the math module
> > > 16.0
```

### Comments

**_[Comments](https://realpython.com/python-comments-guide/#python-commenting-basics)_** in Python start with a `#` that is not part of a string, and end at line termination. Unlike many other programming languages, Python **does not support** multi-line comment marks. Each line of a comment block must start with the `#` character.

### Docstrings

The first statement of a function body can optionally be a **_[docstring](https://docs.python.org/3/tutorial/controlflow.html#tut-docstrings)_**, which concisely summarizes the function or object's purpose. Docstrings are declared using triple double quotes (""") indented at the same level as the code block:

```py
# An example from PEP257 of a multi-line docstring.

def complex(real=0.0, imag=0.0):
"""Form a complex number.

    Keyword arguments:
    real -- the real part (default 0.0)
    imag -- the imaginary part (default 0.0)
    """

    if imag == 0.0 and real == 0.0:
        return complex_zero
```

Docstrings are read by automated documentation tools and are returned by calling the special attribute .\_\_doc\_\_ on the function, method, or class name. Docstring conventions are laid out in PEP257.

Docstrings can also function as lightweight unit tests, which will be covered in a later exercise.

```py
# An example on a user-defined function.

> > > def number_to_the_power_of(number_one, number_two):

        """Raise a number to an arbitrary power.

        :param number_one: int the base number.
        :param number_two: int the power to raise the base number to.
        :return: int - number raised to power of second number

        Takes number_one and raises it to the power of number_two, returning the result.
        """

        return number_one ** number_two

...

# Calling the .**doc** attribute of the function and printing the result.

> > > print(number_to_the_power_of.**doc**)
> > > Raise a number to an arbitrary power.

    :param number_one: int the base number.
    :param number_two: int the power to raise the base number to.
    :return: int - number raised to power of second number

    Takes number_one and raises it to the power of number_two, returning the result.
```

### Instructions

You're going to write some code to help you cook a gorgeous lasagna from your favorite cookbook.

You have five tasks, all related to cooking your recipe.

Task 1 **Define expected bake time in minutes**

Define an EXPECTED_BAKE_TIME constant that returns how many minutes the lasagna should bake in the oven. According to your cookbook, the Lasagna should be in the oven for 40 minutes:

```py
> > > import lasagna
> > > lasagna.EXPECTED_BAKE_TIME
> > > 40
```

Task 2. **Calculate Remaining Bake time in minutes**
Implement the bake_time_remaining() function that takes the actual minutes the lasagna has been in the oven as an argument and returns how many minutes the lasagna still needs to bake based on the EXPECTED_BAKE_TIME.

```py
>>> from lasagna import bake_time_remaining
>>> bake_time_remaining(30)
10
```

Task 3. **Calculate Preparation time in minutes**
Implement the preparation_time_in_minutes(number_of_layers) function that takes the number of layers you want to add to the lasagna as an argument and returns how many minutes you would spend making them. Assume each layer takes 2 minutes to prepare.

```py
>>> from lasagna import preparation_time_in_minutes
>>> preparation_time_in_minutes(2)
4
```

Task 4. **Calculate total elapsed time (prep + bake) in minutes**

Implement the elapsed_time_in_minutes(number_of_layers, elapsed_bake_time) function that has two parameters: number_of_layers (the number of layers added to the lasagna) and elapsed_bake_time (the number of minutes the lasagna has been baking in the oven). This function should return the total number of minutes you've been cooking, or the sum of your preparation time and the time the lasagna has already spent baking in the oven.

```py
>>> from lasagna import elapsed_time_in_minutes
>>> elapsed_time_in_minutes(3, 20)
26
```

Task 5. **Update the recipe with notes**

Go back through the recipe, adding "notes" in the form of function docstrings.

```py
def elapsed_time_in_minutes(number_of_layers, elapsed_bake_time):
    """Calculate the elapsed cooking time.

    :param number_of_layers: int - the number of layers in the lasagna.
    :param elapsed_bake_time: int - elapsed cooking time.
    :return: int - total time elapsed (in minutes) preparing and cooking.

    This function takes two integers representing the number of lasagna layers and the
    time already spent baking and calculates the total elapsed minutes spent cooking the
    lasagna.
    """
```
