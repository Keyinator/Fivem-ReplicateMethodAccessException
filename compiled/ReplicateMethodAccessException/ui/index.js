window.addEventListener('message', (event) => {
    if (event.data.action !== "test")
        return;

    fetch(`https://ReplicateMethodAccessException/nuiCallback`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json; charset=UTF-8',
        },
        body: JSON.stringify({
            data: "Test"
        })
    }).then(resp => resp.json()); 
});