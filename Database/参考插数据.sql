USE ClothesFirm;


INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130032','00000003','刘坤',50000,'门市经理','15600550705');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130033','00000003','胡明捷',9000,'门市经理助理','15699762005');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130034','00000003','黄强汉',20000,'门市副经理','15699761990');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130035','00000003','黄临枫',20000,'门市副经理','18611803019');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130036','00000003','胡冰兰',8000,'普通员工','18611803109');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130037','00000003','胡红梅',8000,'普通员工','15652852221');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130038','00000003','江林',8000,'普通员工','18611888301');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130039','00000003','纪亚萍',8000,'普通员工','18611805905');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130040','00000003','孟宪明',8000,'普通员工','15501017687');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130041','00000003','沈国达',8000,'普通员工','15510266619');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130042','00000003','王大伟',8000,'普通员工','15501067580');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130043','00000003','徐菁',8000,'普通员工','15501066639');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130044','00000003','杨其平',8000,'普通员工','15501067009');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130045','00000003','姚慧玲',8000,'普通员工','18511833159');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130046','00000003','周金中',8000,'普通员工','18046566661');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130047','00000003','赵嘉麟',8000,'普通员工','15311113561');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130048','00000003','周凡',8000,'普通员工','13371715516');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130049','00000003','赵翔',8000,'普通员工','13371716626');
INSERT INTO Staff(StaffID,StoreID,StaffName,StaffSalary,StaffPosition,StaffPhone)
	VALUES('04130050','00000003','钟元钊',8000,'普通员工','15311110380');




INSERT INTO Supplier(SupplierID,SupplierName,SupplierAddress)
	VALUES('00000001','七色服装批发市场','杭州市西湖区浙大路200号');
INSERT INTO Supplier(SupplierID,SupplierName,SupplierAddress)
	VALUES('00000002','四季青服装批发市场','杭州市西湖区法云弄15号');
INSERT INTO Supplier(SupplierID,SupplierName,SupplierAddress)
	VALUES('00000003','五道口服装市场','北京市海淀区学清路38号金码大厦');
INSERT INTO Supplier(SupplierID,SupplierName,SupplierAddress)
	VALUES('00000004','大红门服装批发市场','北京市丰台区南苑路15号大红门商贸城4011号');
INSERT INTO Supplier(SupplierID,SupplierName,SupplierAddress)
	VALUES('00000005','金五星服装批发市场','北京市海淀区中关村东路118号');
INSERT INTO Supplier(SupplierID,SupplierName,SupplierAddress)
	VALUES('00000006','动物园服装市场','北京市西城区西外南路12号 ');
INSERT INTO Supplier(SupplierID,SupplierName,SupplierAddress)
	VALUES('00000007','龙兴服装批发','工农路41号');
INSERT INTO Supplier(SupplierID,SupplierName,SupplierAddress)
	VALUES('00000008','汉正街品牌服饰批发广场','京汉大道380号');




INSERT INTO BrandInformation(BrandID,BrandName,BrandDescription)
	VALUES('00000001','World','应至龙服装公司第一品牌，世界闻名，奢侈品牌');
INSERT INTO BrandInformation(BrandID,BrandName,BrandDescription)
	VALUES('00000002','Peace','平民品牌');
INSERT INTO BrandInformation(BrandID,BrandName,BrandDescription)
	VALUES('00000003','SmartMonkey','平民品牌');
INSERT INTO BrandInformation(BrandID,BrandName,BrandDescription)
	VALUES('00000004','Dran','平民品牌');
INSERT INTO BrandInformation(BrandID,BrandName,BrandDescription)
	VALUES('00000005','MagicBird','奢侈品牌');



INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000001','S','10000','00000001');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000002','M','10000','00000001');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000003','L','10000','00000001');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000004','XL','10000','00000001');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000005','XXL','10000','00000001');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000006','XXXL','10000','00000001');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000007','S','1000','00000002');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000008','M','1000','00000002');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000009','L','1000','00000002');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000010','XL','1000','00000002');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000011','XXL','1000','00000002');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000012','XXXL','1000','00000002');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000013','S','2000','00000003');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000014','M','2000','00000003');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000015','L','2000','00000003');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000016','XL','2000','00000003');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000017','XXL','2000','00000003');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000018','XXXL','2000','00000003');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000019','S','1500','00000004');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000020','M','1500','00000004');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000021','L','1500','00000004');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000022','XL','1500','00000004');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000023','XXL','1500','00000004');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000024','XXXL','1500','00000004');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000025','S','15000','00000005');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000026','M','15000','00000005');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000027','L','15000','00000005');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000028','XL','15000','00000005');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000029','XXL','15000','00000005');
INSERT INTO Clothes(ClothesID,ClothesSize,ClothesPrice,BrandID)
	VALUES('00000030','XXXL','15000','00000005');



INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000001','BAEK°','男','北五楼408','15901112967','18766555');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000002','alongKING','男','北五楼133','18800110790','151587665');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000003','crazyMaybe','女','北五楼443','18800123971','166518755');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000004','BlaVer','男','北五楼442','18800101281','665511875');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000005','Summer','女','北五楼332','18800101307','116687555');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000006','Demon','男','北五楼44','18800101352','766118555');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000007','Angle','女','18楼33','18800101375','876651155');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000008','Aries','男','17楼88','18800101752','166187555');
	INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000009','Abandon','男','14楼33','18800101832','118756655');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000010','Sadness','女','北五楼342','18800103817','116587655');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000011','Sunny','女','北五楼342','18800107571','115876655');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000012','Moment ','男','北五楼343','18800108190','115587665');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000013','Black ','男','北五楼342','18800108305','187661555');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000014','Amour ','男','18楼431','18800108582','718165655');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000015','Redundant','男','18楼431','18800108692','766118555');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000016','Moon','女','18楼431','18800109217','661187555');
	INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000017','Raging','男','18楼432','13810859728','655511876');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000018','逆光的少年','男','17楼333','13810860398','766511855');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000019','逆倒尘光','女','17楼393','13810862136','166551875');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000020','斑点水玛线','男','17楼312','13810862879','661187555');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000021','夺爱水果刀','女','14楼767','13810887915','118557665');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000022','深冬','女','北五楼323','13810889316','187616555');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000023','Shoulder','男','北五楼323','13810889316','115587665');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000024','queen','女','北五楼323','13810889839','187616555');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000025','Ince','男','北五楼323','13811166259','117665585');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000026','Ken','男','北五楼323','13810593299','155187665');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000027','Kala','男','北五楼676','13810656833','118655765');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000028','Mandy','女','北五楼123','13522780032','176651855');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000029','Marlow','男','北五楼111','13522780183','187665155');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000030','Matia','男','北五楼111','13522780753','155876655');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000031','Mark','男','18楼212','13522781251','117668555');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000032','Fred','男','18楼212','13522781397','166187555');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000033','钱贞如','女','北五楼101','15767767677','118766555');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000034','李翔','男','北五楼102','15767767678','118766556');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000035','王充','男','北五楼103','15767767679','118766557');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000036','张剑祯','男','北五楼104','15767767680','118766558');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000037','李龙','男','北五楼105','15767767681','118766559');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000038','李剑','男','北五楼106','15767767682','118766560');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000039','褚甜','女','北五楼107','15767767683','118766561');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000040','付国楠','男','北五楼108','15767767684','118766562');
	INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000041','池霆谡','男','学10楼101','15767767685','118766563');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000042','刘鹏','男','学10楼102','15767767686','118766564');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000043','何滋润','女','学10楼103','15767767687','118766565');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000044','李浩飞','男','学10楼104','15767767688','118766566');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000045','边小丽','女','学10楼105','15767767689','118766567');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000046','恬哈努','女','学10楼106','15767767690','118766568');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000047','史努比','男','学10楼107','15767767691','118766569');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000048','维尼','男','学10楼108','15767767692','118766570');
	INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000049','琼恩','男','学17楼101','15767767693','118766571');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000050','奈德','男','学17楼102','15767767694','118766572');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000051','罗柏','男','学17楼103','15767767695','118766573');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000052','爱丽丝','女','学17楼104','15767767696','118766574');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000053','瑟曦','女','学17楼105','15767767697','118766575');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000054','詹姆','男','学17楼106','15767767698','118766576');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000055','山姆','男','学17楼107','15767767699','118766577');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000056','伊耿','男','学17楼108','15767767700','118766578');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000057','劳勃','男','学19楼101','15767767701','118766579');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000058','史坦尼斯','男','学19楼102','15767767702','118766580');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000059','提利尔','男','学19楼103','15767767703','118766581');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000060','丹尼莉丝','女','学19楼104','15767767704','118766582');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000061','露西','女','学19楼105','15767767705','118766583');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000062','丽莉','女','学19楼106','15767767706','118766584');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000063','韩梅梅','女','学19楼107','15767767707','118766585');
INSERT INTO Member(MemberID,MemberName,MemberGender,MemberAddress,MemberPhone,MemberQQ)
	VALUES('00000064','昆卡','男','学19楼108','15767767708','118766586');



INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000013','00000003','00000001','00000001',2050,15);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000014','00000003','00000001','00000002',2050,15);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000015','00000003','00000002','00000003',2050,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000016','00000003','00000002','00000004',2050,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000017','00000003','00000002','00000005',2050,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000018','00000003','00000001','00000006',2050,20);


INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000031','00000003','00000007','00000007',90,20);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000032','00000003','00000007','00000008',90,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000033','00000003','00000008','00000009',95,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000034','00000003','00000008','00000010',95,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000035','00000003','00000007','00000011',90,15);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000036','00000003','00000007','00000012',90,10);


INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000049','00000003','00000007','00000013',190,20);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000050','00000003','00000007','00000014',190,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000051','00000003','00000008','00000015',195,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000052','00000003','00000008','00000016',195,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000053','00000003','00000007','00000017',190,15);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000054','00000003','00000007','00000018',190,10);


INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000067','00000003','00000007','00000019',190,20);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000068','00000003','00000007','00000020',190,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000069','00000003','00000008','00000021',195,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000070','00000003','00000008','00000022',195,30);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000071','00000003','00000007','00000023',190,15);
INSERT INTO ContractInformation(ContractID,StoreID,SupplierID,ClothesID,SupplyPrice,SupplyCount)
	VALUES('00000072','00000003','00000007','00000024',190,10);


INSERT INTO SalesInformation(ClothesID,StoreID,SalesCount)
	VALUES('00000001','00000003',4);
INSERT INTO SalesInformation(ClothesID,StoreID,SalesCount)
	VALUES('00000004','00000003',2);
INSERT INTO SalesInformation(ClothesID,StoreID,SalesCount)
	VALUES('00000005','00000003',5);
INSERT INTO SalesInformation(ClothesID,StoreID,SalesCount)
	VALUES('00000008','00000003',8);
INSERT INTO SalesInformation(ClothesID,StoreID,SalesCount)
	VALUES('00000013','00000003',2);
INSERT INTO SalesInformation(ClothesID,StoreID,SalesCount)
	VALUES('00000015','00000003',4);
INSERT INTO SalesInformation(ClothesID,StoreID,SalesCount)
	VALUES('00000021','00000003',6);
INSERT INTO SalesInformation(ClothesID,StoreID,SalesCount)
	VALUES('00000023','00000003',2);
INSERT INTO SalesInformation(ClothesID,StoreID,SalesCount)
	VALUES('00000018','00000003',1);