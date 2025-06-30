CREATE DATABASE test;
USE test;
CREATE TABLE reserve(
    id int primary key identity(1,1),
    resourceType nvarchar(8) not null,
    responsibleName nvarchar(100) not null,
    DateTimeStart datetime2 not null ,
    hourDuration int not null check (hourDuration > 0 and hourDuration <= 8),
    check (resourceType in ( )),
    check (
        cast(DateTimeStart as time) >= '08:00:00'
        and
        cast(DateTimeStart as time) <= '18:00:00'
    ),
);