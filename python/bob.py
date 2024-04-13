import re

def response(hey_bob):
    """
    This function processes the input 'hey_bob' and returns a response based on the input.
    
    Parameters:
    hey_bob (str): The input to be processed.

    Returns:
    str: The response based on the input.
    """
    if not hey_bob.strip():
        return "Fine. Be that way!"
    if hey_bob.strip().endswith("?"):
        if hey_bob.isupper():
            return "Calm down, I know what I'm doing!"
        else:
            return "Sure."
    if hey_bob.isupper():
        return "Whoa, chill out!"
    return "Whatever."
