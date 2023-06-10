import time

from selenium import webdriver

driver=webdriver.Chrome()

time.sleep(2)

driver.get("https://stomland.by/stomatologija-v-zelenom-luge/")
time.sleep(2)

username=driver.find_element_by_id("form-field-name")
username.send_keys("Александр")

time.sleep(2)

secondname=driver.find_element_by_name("form_fields[field_69855a9]")
secondname.send_keys("+375123456789")

email=driver.find_element_by_name("form_fields[email]")
email.send_keys("test@gmail.com")

time.sleep(2)

ph=driver.find_element_by_name("form_fields[message]")
ph.send_keys("123467")

time.sleep(2)

submit_button=driver.find_element_by_class_name("elementor-button.elementor-size-sm")

submit_button.click()
time.sleep(2)

driver.quit()

