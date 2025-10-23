# DuckovConverter

- int.MaxValue
  - 2147483647
  - ////fw==

Regex Replace:
```
("dataType" : 2,\n\s+"data" : ")\S+(",)
$1\/\/\/\/fw==$2
```