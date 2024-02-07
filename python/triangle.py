"""
This module contains functions for working with triangles.
"""

def is_a_triangle(sides):
    """
    Check if the given sides form a triangle.

    Args:
        sides: a list of three integers representing the lengths of the sides of the triangle.

    Returns:
        True if the sides form a triangle, False otherwise.
    """
    return 2 * max(sides) < sum(sides)

def equilateral(sides):
    """
    Check if the given sides form an equilateral triangle.

    Args:
        sides: a list of three integers representing the lengths of the sides of the triangle.

    Returns:
        True if the sides form an equilateral triangle, False otherwise.
    """
    return len(set(sides)) == 1 and is_a_triangle(sides)


def isosceles(sides):
    """
    Determine if the sides form an isosceles triangle.

    Args:
        sides: a list of three integers representing the lengths of the sides of the triangle.

    Returns:
        True if the sides form an isosceles triangle, False otherwise.
    """
    return len(set(sides)) <= 2 and is_a_triangle(sides)


def scalene(sides):
    """
    Determine if the given sides form a scalene triangle.
    
    Args:
        sides: a list of three integers representing the lengths of the sides of the triangle.
        
    Returns:
        True if the sides form a scalene triangle, False otherwise.
    """
    return len(set(sides)) == 3 and is_a_triangle(sides)
