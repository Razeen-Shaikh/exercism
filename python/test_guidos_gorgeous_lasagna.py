"""Test the guidos_gorgeous_lasagna module."""

import unittest
import guidos_gorgeous_lasagna as main
    
def test_bake_time_remaining():
    """Test the bake time remaining function."""

    # Test case 1: elapsed time is 0
    assert main.bake_time_remaining(0) == main.EXPECTED_BAKE_TIME

    # Test case 2: elapsed time is less than expected bake time
    assert main.bake_time_remaining(10) == main.EXPECTED_BAKE_TIME - 10

    # Test case 3: elapsed time is equal to expected bake time
    assert main.bake_time_remaining(main.EXPECTED_BAKE_TIME) == 0

    # Test case 4: elapsed time is greater than expected bake time
    assert main.bake_time_remaining(30) == -20

def test_preparation_time_in_minutes():
    """Test the preparation_time_in_minutes function."""

    # Test case 1: number of layers is 0
    assert main.preparation_time_in_minutes(0) == 0

    # Test case 2: number of layers is 1
    assert main.preparation_time_in_minutes(1) == 2

    # Test case 3: number of layers is 2
    assert main.preparation_time_in_minutes(2) == 4

    # Test case 4: number of layers is 3
    assert main.preparation_time_in_minutes(3) == 6

def test_elapsed_time_in_minutes():
    """Test the elapsed_time_in_minutes function."""
    # Test case 1: number of layers is 0
    assert main.elapsed_time_in_minutes(0, 0) == 0

    # Test case 2: number of layers is 1
    assert main.elapsed_time_in_minutes(1, 0) == 2

    # Test case 3: number of layers is 2
    assert main.elapsed_time_in_minutes(2, 0) == 4

    # Test case 4: number of layers is 3
    assert main.elapsed_time_in_minutes(3, 0) == 6

if __name__ == "__main__":
    unittest.main()