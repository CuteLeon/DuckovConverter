# DuckovConverter

- int.MaxValue
  - 2147483647
  - ////fw==

#Regex Replace:

```
("dataType" : 2,\n\s+"data" : ")\S+(",)
$1\/\/\/\/fw==$2
```

```
("dataType" : 2,\n\s+"data" : ")\S+(",)
$1ZAAAAA==$2
```