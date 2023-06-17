import unittest
import calc_test2

calcTestSuite=unittest.TestSuite()
calcTestSuite.addTest(unittest.makeSuite(calc_test2.CalcBasicTests))
calcTestSuite.addTest(unittest.makeSuite(calc_test2.CalcExTests))
print("Количество тестов: "+str(calcTestSuite.countTestCases())+"\n")

runner=unittest.TextTestRunner(verbosity=2)
runner.run(calcTestSuite)