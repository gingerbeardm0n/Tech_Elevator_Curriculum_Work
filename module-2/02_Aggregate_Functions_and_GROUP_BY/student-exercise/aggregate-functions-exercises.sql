-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in units of one million US Dollars
--   The value immediately after the problem statement is the expected number 
--   of rows that should be returned by the query.

-- 1. The name and state plus population of all cities in states that border Ohio 
-- (i.e. cities located in Pennsylvania, West Virginia, Kentucky, Indiana, and 
-- Michigan).  
-- The name and state should be returned as a single column called 
-- name_and_state and should contain values such as ‘Detroit, Michigan’.  
-- The results should be ordered alphabetically by state name and then by city 
-- name. 
-- (19 rows)

SELECT (name + ', ' + district) AS name_and_state, population FROM city
WHERE district IN ('Pennsylvania', 'West Virginia', 'Kentucky', 'Indiana', 'Michigan')
ORDER BY district, name


-- 2. The name, country code, and region of all countries in Africa.  The name and
-- country code should be returned as a single column named country_and_code 
-- and should contain values such as ‘Angola (AGO)’ 
-- (58 rows)

SELECT (name + ' (' + code + ')') AS country_and_code, region FROM country
WHERE continent = 'Africa'

-- 3. The per capita GNP (i.e. GNP multipled by 1000000 then divided by population) of all countries in the 
-- world sorted from highest to lowest. Recall: GNP is express in units of one million US Dollars 
-- (highest per capita GNP in world: 37459.26)

SELECT ((gnp*1000000)/population) AS gnp_per_person FROM country
WHERE population > 0
ORDER BY gnp_per_person desc

-- 4. The average life expectancy of countries in South America.
-- (average life expectancy in South America: 70.9461)

SELECT avg(lifeexpectancy) FROM country
WHERE continent = 'South America'

-- 5. The sum of the population of all cities in California.
-- (total population of all cities in California: 16716706)

SELECT sum(population) FROM city
WHERE district = 'California'

-- 6. The sum of the population of all cities in China.
-- (total population of all cities in China: 175953614)

SELECT sum(population) FROM city
WHERE countrycode = 'CHN'

-- 7. The maximum population of all countries in the world.
-- (largest country population in world: 1277558000)

SELECT max(population) FROM country

-- 8. The maximum population of all cities in the world.
-- (largest city population in world: 10500000)

SELECT max(population) FROM city

-- 9. The maximum population of all cities in Australia.
-- (largest city population in Australia: 3276207)

SELECT max(population) FROM city
WHERE countrycode = 'AUS'

-- 10. The minimum population of all countries in the world.
-- (smallest_country_population in world: 50)

SELECT min(population) FROM country
WHERE population > 0

-- 11. The average population of cities in the United States.
-- (avgerage city population in USA: 286955.3795)

SELECT avg(population) FROM city
WHERE countrycode = 'USA'

-- 12. The average population of cities in China.
-- (average city population in China: 484720.6997 approx.)

SELECT avg(population) FROM city
WHERE countrycode = 'CHN'

-- 13. The surface area of each continent ordered from highest to lowest.
-- (largest continental surface area: 31881000, "Asia")

SELECT continent, sum(surfacearea) AS continent_surf_area FROM country
GROUP BY continent
ORDER BY continent_surf_area desc

-- 14. The highest population density (population divided by surface area) of all 
-- countries in the world. 
-- (highest population density in world: 26277.7777)

SELECT (population/surfacearea) AS popDensity FROM country
ORDER BY popDensity desc

-- 15. The population density and life expectancy of the top ten countries with the 
-- highest life expectancies in descending order. 
-- (highest life expectancies in world: 83.5, 166.6666, "Andorra")

SELECT TOP 10 name, (population/surfacearea) AS popDensity, lifeexpectancy FROM country
ORDER BY lifeexpectancy desc

-- 16. The difference between the previous and current GNP of all the countries in 
-- the world ordered by the absolute value of the difference. Display both 
-- difference and absolute difference.
-- (smallest difference: 1.00, 1.00, "Ecuador")

SELECT name, abs(gnp - gnpold) AS absolute_difference, (gnp - gnpold) AS difference_in_GNP  FROM country
WHERE gnp IS NOT NULL
AND gnpold IS NOT NULL
ORDER by absolute_difference

-- 17. The average population of cities in each country (hint: use city.countrycode)
-- ordered from highest to lowest.
-- (highest avg population: 4017733.0000, "SGP")

SELECT countrycode, AVG(population) AS avgerage_population FROM city
GROUP BY countrycode
ORDER By avgerage_population desc;

-- 18. The count of cities in each state in the USA, ordered by state name.
-- (45 rows)

SELECT district, count(*) AS number_of_cities FROM city
WHERE countrycode = 'USA'
GROUP BY district
	
-- 19. The count of countries on each continent, ordered from highest to lowest.
-- (highest count: 58, "Africa")

SELECT continent, count(*) AS number_of_countries FROM country
GROUP BY continent
ORDER BY number_of_countries desc
	
-- 20. The count of cities in each country ordered from highest to lowest.
-- (largest number of  cities ib a country: 363, "CHN")

SELECT count(*) AS city_count FROM city
Group BY countrycode
Order BY city_count desc

-- 21. The population of the largest city in each country ordered from highest to 
-- lowest.
-- (largest city population in world: 10500000, "IND")

SELECT countrycode, max(population) AS MaxPop FROM city
GROUP BY countrycode
ORDER BY MaxPop desc


-- 22. The average, minimum, and maximum non-null life expectancy of each continent 
-- ordered from lowest to highest average life expectancy. 
-- (lowest average life expectancy: 52.5719, 37.2, 76.8, "Africa")

SELECT continent, 
avg(lifeexpectancy) AS Avg_Life_EXpectency, 
min(lifeexpectancy)AS MIN_Life_EXpectency, 
max(lifeexpectancy)AS MAX_Life_EXpectency 
FROM country
WHERE lifeexpectancy IS NOT NULL
GROUP BY continent