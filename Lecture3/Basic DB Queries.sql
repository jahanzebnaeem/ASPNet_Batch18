/****** Script for SelectTopNRows command from SSMS  ******/
select * from Country;
select * from City;

select City.Name, Country.Name
	From Country Inner Join City
	on Country.CountryID = City.CountryID
	Where Country.CountryID = 1;