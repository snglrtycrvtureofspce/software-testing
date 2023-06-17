import math
import time

from selenium import webdriver
from selenium.webdriver.common.by import By

link = "http://suninjuly.github.io/huge_form.html"

try:
    browser = webdriver.Chrome()
    browser.get(link)
    
    time.sleep(3)
    
    elements = browser.find_elements(By.TAG_NAME, "input")
    for element in elements:
        element.send_keys("Привет!")
        
    button = browser.find_element(By.CSS_SELECTOR, "button.btn")
    button.click()
    
finally:
    time.sleep(10)
    browser.quit()
