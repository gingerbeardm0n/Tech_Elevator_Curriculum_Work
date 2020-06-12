-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)

SELECT * FROM actor;

SELECT * FROM actor a
JOIN film_actor fa ON a.actor_id = fa.actor_id
WHERE a.first_name = 'Nick'
AND a.last_name = 'Stallone'

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)

SELECT * FROM actor a
JOIN film_actor fa ON a.actor_id = fa.actor_id
WHERE a.last_name = 'Reynolds'

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)

SELECT * FROM actor a
JOIN film_actor fa ON a.actor_id = fa.actor_id
WHERE a.last_name = 'Dean'

-- 4. All of the the ‘Documentary’ films
-- (68 rows)

SELECT * FROM category

SELECT f.title FROM film_category fc
JOIN film f ON fc.film_id = f.film_id
WHERE category_id = 6

-- 5. All of the ‘Comedy’ films
-- (58 rows)

SELECT * FROM category

SELECT f.title FROM film_category fc
JOIN film f ON fc.film_id = f.film_id
WHERE category_id = 5

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)

SELECT * FROM category

SELECT f.title, rating FROM film_category fc
JOIN film f ON fc.film_id = f.film_id
WHERE category_id = 3
AND rating = 'G'

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)

SELECT * FROM category

SELECT f.title, rating, length  FROM film_category fc
JOIN film f ON fc.film_id = f.film_id
WHERE category_id = 8
AND rating = 'G'
AND length < 120

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)

SELECT f.title, f.rating FROM actor a
JOIN film_actor fa ON a.actor_id = fa.actor_id
JOIN film f ON fa.film_id = f.film_id
WHERE last_name = 'Leigh'
AND rating = 'G'

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)

SELECT * FROM category

SELECT f.title, release_year FROM film_category fc
JOIN film f ON fc.film_id = f.film_id
WHERE category_id = 14
AND release_year = '2006'

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)

SELECT * FROM category

SELECT title FROM actor a
JOIN film_actor fa ON a.actor_id = fa.actor_id
JOIN film f ON fa.film_id = f.film_id
JOIN film_category fc ON f.film_id = fc.film_id
WHERE last_name = 'Stallone'
AND category_id = '1'

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)

SELECT store_id ,address, city, district, country FROM store s
JOIN address a ON s.address_id = a.address_id
JOIN city ci ON a.city_id = ci.city_id
JOIN country co ON ci.country_id = co.country_id

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)

SELECT * FROM store
SELECT * FROM staff

SELECT s.store_id , address, (stf.first_name + ' ' + stf.last_name) AS manager_name FROM store s
JOIN address a ON s.address_id = a.address_id
JOIN staff stf ON s.store_id = stf.store_id

-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)

SELECT TOP 10 c.first_name, c.last_name, count(*) AS amount_of_rentals FROM rental r
JOIN customer c ON r.customer_id = c.customer_id
GROUP BY c.customer_id, c.last_name, c.first_name
ORDER BY amount_of_rentals desc

-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)

SELECT TOP 10 c.customer_id, sum(amount) AS totalAmount, c.first_name, c.last_name  FROM payment p
JOIN customer c ON p.customer_id = c.customer_id
GROUP BY c.customer_id, c.first_name, c.last_name
ORDER BY totalAmount desc

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that an employee may work at multiple stores.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

SELECT p.staff_id, stf.store_id , count(p.rental_id) AS numner_of_rentals FROM payment p
JOIN rental r ON p.rental_id = r.rental_id
JOIN staff stf ON r.staff_id = stf.staff_id
JOIN store s ON stf.store_id = s.store_id
GROUP BY p.staff_id, stf.store_id
 

-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)

--count(rental_id) as Rental_Count Order BY Rental_Count desc

SELECT TOP 10 i.film_id, count(rental_id) as Rental_Count, title FROM rental r
JOIN inventory i ON r.inventory_id = i.inventory_id
JOIN film f ON i.film_id = f.film_id
GROUP BY i.film_id, title
order by Rental_Count desc



-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)

SELECT TOP 5 c.name, count(rental_id) AS #_of_time_category_was_rented FROM rental r
JOIN inventory i ON r.inventory_id = i.inventory_id
JOIN film f ON i.film_id = f.film_id
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON fc.category_id = c.category_id
group by fc.category_id, c.name
order by #_of_time_category_was_rented desc


-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)

SELECT TOP 5 title, c.name, count(rental_id) AS number_of_rentals FROM rental r
JOIN inventory i ON r.inventory_id = i.inventory_id
JOIN film f ON i.film_id = f.film_id
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON fc.category_id = c.category_id
WHERE c.name = 'Action'
GROUP BY i.film_id, title, c.name
ORDER BY number_of_rentals desc

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)

SELECT fa.actor_id, (first_name + ' ' + last_name) AS actor_name, 
count(rental_id) AS number_of_rentals FROM rental r
JOIN inventory i ON r.inventory_id = i.inventory_id
JOIN film f ON i.film_id = f.film_id
JOIN film_actor fa ON f.film_id = fa.film_id
JOIN actor a ON fa.actor_id = a.actor_id
Group BY fa.actor_id, first_name, last_name
ORDER BY number_of_rentals desc

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)

SELECT  TOP 5 first_name, last_name, c.name, count(rental_id) AS number_of_rentals FROM rental r
JOIN inventory i ON r.inventory_id = i.inventory_id
JOIN film f ON i.film_id = f.film_id
JOIN film_actor fa ON f.film_id = fa.film_id
JOIN actor a ON fa.actor_id = a.actor_id
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON fc.category_id = c.category_id
WHERE c.name = 'Comedy'
GROUP BY a.actor_id, c.name, first_name, last_name
ORDER BY number_of_rentals desc