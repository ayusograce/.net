Submission

-- Evidence from the end of the module: Create a web API with ASP.NET Core controllers showing the existing content, and your additional record.
Comand:
GET {{ContosoPizza_HostAddress}}/pizza/
Accept: application/json

Response:
HTTP/1.1 200 OK
Connection: close
Content-Type: application/json; charset=utf-8
Date: Wed, 13 May 2026 04:59:07 GMT
Server: Kestrel
Transfer-Encoding: chunked

[
  {
    "id": 1,
    "name": "Classic Italian",
    "isGlutenFree": false
  },
  {
    "id": 2,
    "name": "Veggie",
    "isGlutenFree": true
  },
  {
    "id": 3,
    "name": "Pepperoni",
    "isGlutenFree": false
  }
]

-- A text copy of your working sales summary function for Part 2.

Sales summary
-------------
Total sales: $2.012,20
 Details: 
 - (folder: stores) sales.json: $88,88
- (folder: 201) sales.json: $501,22
- (folder: 201) salestotals.json: $0,00
- (folder: 202) sales.json: $1.234,22
- (folder: 202) salestotals.json: $0,00
- (folder: 203) sales.json: $99,00
- (folder: 203) salestotals.json: $0,00
- (folder: 204) sales.json: $88,88
- (folder: 204) salestotals.json: $0,00


