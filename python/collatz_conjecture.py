def steps(number):
    """
    This function calculates the number of steps required to reach 1
    based on the Collatz conjecture for a given positive integer.
    
    Parameters:
        number (int): The positive integer for which steps are to be calculated
    
    Returns:
        int: The number of steps required to reach 1
    """
    if number <= 0:
        raise ValueError("Only positive integers are allowed")
    count = 0
    while number != 1:
        if number % 2 == 0:
            number //= 2
        else:
            number = 3 * number + 1
        count += 1
    return count
