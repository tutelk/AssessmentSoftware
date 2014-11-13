drop database if exists TestAssessment;
create database if not exists TestAssessment;

use TestAssessment;

drop table if exists _tbUser;
create table _tbUser(
编号 varchar(5) not null,
姓名 nvarchar(20),
密码 varchar(10),
职称 nvarchar(20),
工作单位 nvarchar(50),
联系电话 nvarchar(20),
权重 double,
是否管理员 char(2),
primary key(编号)
);

drop table if exists _tbNode;
create table _tbNode(
编号 varchar(5) not null,
名称 nvarchar(20),
父节点 varchar(5),
节点描述 text,
primary key(编号)
);

drop table if exists _tbAssessment;
create table _tbAssessment(
评估人 varchar(5) not null,
评估节点 varchar(5) not null,
各级别隶属度 text,
子节点判断矩阵 text,
权重 double,
隶属级别 varchar(20),
可信度值 double,
primary key(评估人,评估节点),
foreign key(评估人) REFERENCES  _tbUser(编号) on delete cascade on update cascade,
foreign key(评估节点) REFERENCES  _tbNode(编号) on delete cascade on update cascade
);

DELIMITER |
create procedure make_tbAssessment()
begin
	declare userNumber varchar(5);
	declare nodeNumber varchar(5);
	declare stop int default 0;
	declare _cursor cursor for select _tbUser.编号,_tbNode.编号 from _tbUser,_tbNode;
	declare continue handler for not found set stop=null;
	open _cursor;
	fetch _cursor into userNumber,nodeNumber;
	while stop is not null do
		insert into _tbAssessment(评估人,评估节点)
		values (userNumber,nodeNumber);
		fetch _cursor into userNumber,nodeNumber;
	end while;
	close _cursor;
end|
DELIMITER ;