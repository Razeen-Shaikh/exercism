"""Test the hello_world module."""
import unittest
import hello_world as main

class TestHelloFunction(unittest.TestCase):
    """Test the hello function."""
    def test_hello_returns_greeting_string(self):
        """Test that the hello function returns a greeting string."""
        self.assertEqual(main.hello(), 'Hello, World!')

if __name__ == '__main__':
    unittest.main()
