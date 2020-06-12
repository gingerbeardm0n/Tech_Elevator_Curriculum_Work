-- firstname, lastname and title of all employees with a position

SELECT * FROM employee;
SELECT * FROM position;

SELECT employee.firstname, employee.lastname, position.title FROM employee
INNER JOIN position
ON employee.position = position.id

SELECT e.firstname, e.lastname, p.title FROM employee e
INNER JOIN position p
ON e.position = p.id

SELECT e.firstname, e.lastname, p.title FROM employee e
JOIN position p
ON e.position = p.id

-- title and department name of all positions assigned to an department
SELECT * FROM position

SELECT * FROM department

SELECT * FROM position p
JOIN department d
ON p.department = d.id

SELECT p.title, d.name FROM position p
JOIN department d
ON p.department = d.id

-- firstname, lastname, title, and department name of all assigned employees

SELECT * FROM department

SELECT * FROM employee

SELECT * FROM position

SELECT e.firstname, e.lastname, p.title, d.name AS Department_Name FROM employee e
JOIN position p ON e.position = p.id
JOIN department d on p.department = d.id

-- firstname and lastname of all employees (assigned or not), include title for those that are assigned
SELECT * FROM employee

SELECT * FROM position

SELECT * FROM employee e
LEFT OUTER JOIN position p ON e.position = p.id

SELECT e.firstname, e.lastname, p.title FROM employee e
LEFT OUTER JOIN position p ON e.position = p.id

SELECT e.firstname, e.lastname, p.title FROM employee e
RIGHT JOIN position p ON e.position = p.id

SELECT e.firstname, e.lastname, p.title FROM position p
RIGHT JOIN employee e ON e.position = p.id

-- all position titles (assigned or not) and all employees assigned to a position (firstname and lastname)


-- above, with the opposite outer join (left or right)


-- show all employees, asigned or not (firstname and lastname) and all poistion titles, asigned or not. Show mattches where they exist (FULL OUTER JOIN)

SELECT * FROM employee e
FULL JOIN position p ON e.position = p.id

-- show all possible combinations of employees (firstname and lastname) and position titles, whether the combinations exist or not (CROSS JOIN)

SELECT * FROM employee e
CROSS JOIN position p



--
--
--








SELECT e.firstname, e.lastname, p.title
FROM employee e
INNER JOIN position p on e.position = p.id
-- JOIN position p on e.position = p.id

SELECT p.title, d.name
FROM position p 
INNER JOIN department d on p.department = d.id

SELECT e.firstname, e.lastname, p.title, d.name
FROM employee e
INNER JOIN position p on e.position = p.id
INNER JOIN department d on p.department = d.id


SELECT e.firstname, e.lastname, p.title
FROM employee e
LEFT OUTER JOIN position p on e.position = p.id
--LEFT JOIN position p on e.position = p.id

SELECT e.firstname, e.lastname, p.title
FROM employee e
RIGHT OUTER JOIN position p on e.position = p.id


SELECT e.firstname, e.lastname, p.title
FROM position p 
LEFT OUTER JOIN employee e on e.position = p.id


SELECT e.firstname, e.lastname, p.title
FROM employee e
FULL OUTER JOIN position p on e.position = p.id
--FULL JOIN position p on e.position = p.id


SELECT e.firstname, e.lastname, p.title
FROM employee e
CROSS JOIN position p 



