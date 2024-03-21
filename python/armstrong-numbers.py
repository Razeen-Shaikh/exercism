def is_armstrong_number(number):
    """
    Check if a number is an Armstrong number.

    Parameters:
        number (int): The number to check for being an Armstrong number.

    Returns:
        bool: True if the number is an Armstrong number, False otherwise.
    """
    num_str = str(number)
    num_digits = len(num_str)

    return sum(int(digit) ** num_digits for digit in num_str) == number
