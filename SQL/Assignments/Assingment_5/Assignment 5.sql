----------employee payroll -question 1--------------------

-- create table
create table emp_payroll
(
    emp_id int primary key,
    emp_name varchar(50),
    salary decimal(10,2)
);

-- insert sample data
insert into emp_payroll values (1, 'arun', 50000);
insert into emp_payroll values (2, 'kiran', 60000);
select * from emp_payroll
-- create procedure
go
create procedure generate_payslip
    @emp_id int
as
begin
    declare 
        @emp_name varchar(50),
        @salary decimal(10,2),
        @hra decimal(10,2),
        @da decimal(10,2),
        @pf decimal(10,2),
        @it decimal(10,2),
        @deductions decimal(10,2),
        @gross decimal(10,2),
        @net decimal(10,2)

    select 
        @emp_name = emp_name,
        @salary = salary
    from emp_payroll
    where emp_id = @emp_id

    set @hra = @salary * 0.10
    set @da = @salary * 0.20
    set @pf = @salary * 0.08
    set @it = @salary * 0.05

    set @deductions = @pf + @it
    set @gross = @salary + @hra + @da
    set @net = @gross - @deductions

    print '----------- payslip -----------'
    print 'employee id   : ' + cast(@emp_id as varchar)
    print 'employee name : ' + @emp_name
    print '--------------------------------'
    print 'basic salary  : ' + cast(@salary as varchar)
    print 'hra (10%)     : ' + cast(@hra as varchar)
    print 'da (20%)      : ' + cast(@da as varchar)
    print '--------------------------------'
    print 'gross salary  : ' + cast(@gross as varchar)
    print 'pf (8%)       : ' + cast(@pf as varchar)
    print 'it (5%)       : ' + cast(@it as varchar)
    print 'deductions    : ' + cast(@deductions as varchar)
    print '--------------------------------'
    print 'net salary    : ' + cast(@net as varchar)
    print '--------------------------------'
end;
go
-- execute
exec generate_payslip 1;

--------------------trigger question 2--------------------

-- create holidays table
create table holidays
(
    holiday_date date,
    holiday_name varchar(50)
);

-- insert holiday data
insert into holidays values ('2026-01-26','republic day');
insert into holidays values ('2026-08-15','independence day');
insert into holidays values ('2026-11-12','diwali');
insert into holidays values ('2026-10-02','gandhi jayanti');
select * from holidays
-- create trigger on emp table
go
create trigger trg_block_on_holiday
on emp_payroll
for insert, update, delete
as
begin
    declare @today date
    declare @holiday_name varchar(50)

    set @today = cast(getdate() as date)

    select @holiday_name = holiday_name
    from holidays
    where holiday_date = @today

    if @holiday_name is not null
    begin
        raiserror ('due to %s you cannot manipulate data',16,1,@holiday_name)
        rollback transaction
    end
end;
go

insert into emp_payroll values (4,'arunima',70000);
select * from emp_payroll
insert into holidays values (cast(getdate() as date), 'test holiday');
insert into emp_payroll values (6,'karan',60000);