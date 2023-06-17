import unittest
import calc_test2

testLoad=unittest.TestLoader()
suites=testLoad.loadTestsFromName("calc_test2.CalcBasicTests")
print("Количество тестов: "+ str(suites.countTestCases())+"\n")

runner=unittest.TextTestRunner(verbosity=2)
runner.run(suites)