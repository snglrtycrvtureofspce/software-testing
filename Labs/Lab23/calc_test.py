import unittest
import calc

class CalcTest(unittest.TestCase):
	"""Тест для калькулятора"""

	@classmethod
	def setUpClass(cls):
		"""Декоратор перед вызовом тестового класса"""
		print("setUpClass")
		print("==========")

	@classmethod
	def tearDownClass(cls):
		"""Декоратор после вызова тестового класса"""
		print("==========")
		print("tearDownClass")

	def setUp(self):
		"""Это вызывается перед каждым тестом"""
		print("Set up for ["+self.shortDescription()+"]")


	def tearDown(self):
		"""Это вызывается после каждого теста"""
		print("Tear down for ["+self.shortDescription()+"]")
		print("")

	def test_add(self):
		"""Тест для операции сложения"""
		print("id: " +self.id())
		self.assertEqual(calc.add(6,2),8)

	def test_sub(self):
		"""Тест для операции вычитания"""
		print("id: " +self.id())
		self.assertEqual(calc.sub(8,6),2)

	def test_mul(self):
		"""Тест для операции умножения"""
		print("id: " +self.id())
		self.assertEqual(calc.mul(7,5),35)

	def test_div(self):
		"""Тест для операции деления"""
		print("id: " +self.id())
		self.assertEqual(calc.div(16,4),4)

if __name__=='__main__':
	unittest.main()
