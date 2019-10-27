async function getData() {
    const resultFromAzureFunction = await fetch("http://localhost:7071/api/HelloWorld")
    const resultObject = await resultFromAzureFunction.json()
    let title = document.createElement("h1")
    title.id = "title"
    title.textContent = resultObject.message
    document.getElementById("body").appendChild(title)
}