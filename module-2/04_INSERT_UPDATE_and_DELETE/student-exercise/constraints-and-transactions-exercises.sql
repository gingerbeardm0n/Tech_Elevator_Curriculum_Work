-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**



SET IDENTITY_INSERT actor ON 

SET IDENTITY_INSERT film ON 

SET IDENTITY_INSERT film_actor ON


-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

SELECT * FROM actor

INSERT INTO actor (actor_id, first_name, last_name)
VALUES (201, 'Hampton', 'Avenue' )

INSERT INTO actor(actor_id, first_name, last_name)
VALUES (202, 'Lisa', 'Byway' )

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

SELECT * FROM language

SELECT * FROM film
WHERE title = 'Euclidean PI'

SELECT * 
FROM film
WHERE film_id = 1002

UPDATE film  SET description = 'The epic story of Euclid as a pizza delivery boy in ancient Greece'
WHERE film_id = 1002
 

INSERT INTO film (title, description, release_year, language_id, length)
VALUES ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in
-- ancient Greece', 2008, 1, 198)

--film id 1002

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

INSERT INTO film_actor (film_id, actor_id)
VALUES (1002, 101)

INSERT INTO film_actor (film_id, actor_id)
VALUES (1002, 102)

SELECT * FROM film_actor
ORDER BY actor_id desc
SELECT * FROM actor

-- 4. Add Mathmagical to the category table.

INSERT INTO category(name)
VALUES ('Mathmagical')

Select * FROM category

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

SELECT * FROM film
WHERE title IN ('Euclidean PI','EGG IGBY', 'KARATE MOON', 'RANDOM GO', 'YOUNG LANGUAGE')

--274
--494
--714
--996
--1002

SELECT * FROM film_category
INSERT INTO film_category(film_id, category_id)
VALUES (274, 17)
INSERT INTO film_category(film_id, category_id)
VALUES (494, 17)
INSERT INTO film_category(film_id, category_id)
VALUES (714, 17)
INSERT INTO film_category(film_id, category_id)
VALUES (996, 17)
INSERT INTO film_category(film_id, category_id)
VALUES (1002, 17)

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

UPDATE film  SET rating = 'G'
WHERE film_id = 274 

UPDATE film  SET rating = 'G'
WHERE film_id = 494 

UPDATE film  SET rating = 'G'
WHERE film_id = 714 

UPDATE film  SET rating = 'G'
WHERE film_id = 996 

UPDATE film  SET rating = 'G'
WHERE film_id = 1002 

SELECT * FROM film
WHERE title IN ('Euclidean PI','EGG IGBY', 'KARATE MOON', 'RANDOM GO', 'YOUNG LANGUAGE')

-- 7. Add a copy of "Euclidean PI" to all the stores.

SELECT * FROM inventory
Order BY inventory_id desc

INSERT INTO inventory (film_id, store_id)
VALUES (1002, 1)
INSERT INTO inventory (film_id, store_id)
VALUES (1002, 2)

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.

SELECT * FROM

-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
