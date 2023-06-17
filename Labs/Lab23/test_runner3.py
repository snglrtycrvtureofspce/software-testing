import unittest
import calc_test2

testLoad=unittest.TestLoader()
suites=testLoad.loadTestsFromModule(calc_test2)

testResult=unittest.TestResult()

runner=unittest.TextTestRunner(verbosity=1)
testResult=runner.run(suites)
print("errors")
print(len(testResult.errors))
print("failures")
print(len(testResult.failures))
print("skipped")
print(len(testResult.skipped))
print("testRun")
print(testResult.testsRun)