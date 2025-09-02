# RentalCar 線上預先車輛租用系統

## 系統說明：
這是一個提供租車用戶可在線上預先租用車輛的系統。系統功能為，租車用戶可以在線上預約租車，而在租用車輛之前，租車用戶必須先註冊自已的帳戶資料後，並進行登入後才可預先租用車輛。在租用車輛時，可以選擇車型、租用時間區間、並計算租金。

請使用 PlantUML 語法，設計租車用戶可進行線上租車的 Sequence Diagram，(租車用戶/Actor) 可呼叫 ToRentalCar() 方法線上租用車輛 ，但在租用車輛之前，得先對 Account 領域物件 呼叫註冊帳號 RegisterAccount() 的方法。

## Use Case Diagrm:
請使用 PlantUML 語法，設計一個租車用戶可進行線上租車的 Use Case Diagram，且在租車時，包含了選擇車型、選擇租用時間、計算租金，也就是說，租車是這個 Use Case Diagram 的主要事件流。

## Sequence Diagram:
在請依照目前的 Use Case 設計，接續設計 Sequence Diagram，一樣使用 PlantUML Script 語法，設計租車用戶可進行線上租車的 Sequence Diagram，(租車用戶/Actor) 可呼叫 ToRentalCar() 方法線上租用車輛 ，但在租用車輛之前，得先對 Account 領域物件，呼叫註冊帳號 RegisterAccount() 的方法，且在租車之前，得先以個人的註冊帳號 UserID 進行登入後，才可租用車輛。