with MYCTE_11_dec
as
(
select * from student_11dec
)
select * from MYCTE_11_dec c inner join student_11dec ct  on c.studentid = ct.studentid