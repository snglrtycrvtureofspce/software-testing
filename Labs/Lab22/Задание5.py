from selenium import webdriver
from selenium.webdriver.common.by import By
import time

link = "http://suninjuly.github.io/find_xpath_form"

try:
    browser = webdriver.Chrome()
    browser.get(link)

    input1 = browser.find_element(By.TAG_NAME, "input")
    input1.send_keys("Aleksandr")
    input2 = browser.find_element(By.NAME, "last_name")
    input2.send_keys("Zenevich")
    input3 = browser.find_element(By.CLASS_NAME, "city")
    input3.send_keys("Minsk")
    input4 = browser.find_element(By.ID, "country")
    input4.send_keys("Belarus")
    button = browser.find_element(By.XPATH, "//button[text()='Submit']")
    button.click()

finally:
    time.sleep(10)
    browser.quit()
