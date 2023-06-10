import time

from selenium import webdriver

driver=webdriver.Chrome()

time.sleep(5)

driver.get("http://bga.by/contacts")
time.sleep(5)

textarea=driver.find_element_by_tag_name("textarea")

textarea.send_keys("Мой первый тест через Selenium")

username=driver.find_element_by_id("124158159")

username.send_keys("Зеневич Александр")

time.sleep(5)
ph = driver.find_element_by_id("124158161")
ph.send_keys("+375291234567")
time.sleep(5)


submit_button=driver.find_element_by_css_selector("#submitFormContacts")

submit_button.click()
time.sleep(5)

driver.quit()

