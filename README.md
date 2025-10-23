# DuckovConverter

- int.MaxValue
  - 2147483647
  - ////fw==

#Regex Replace:

```
("dataType" : 2,\n\s+"data" : ")\S+(",)
$1\/\/\/\/fw==$2
```

100
```
("dataType" : 2,\n\s+"data" : ")\S+(",)
$1ZAAAAA==$2
```

255
```
("dataType" : 2,\n\s+"data" : ")\S+(",)
$1/wAAAA==$2
```

1,000,000
```
("dataType" : 2,\n\s+"data" : ")\S+(",)
$1QEIPAA==$2
```