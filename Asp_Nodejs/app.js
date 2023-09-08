const axios = require('axios');
process.env.NODE_TLS_REJECT_UNAUTHORIZED = '0'; 


const dataToSend = {
    Id: 523,
    Name: 'Pinocchio',
};

axios.post('https://localhost:7193/api/Api', dataToSend)
    .then(response => {
        console.log(response.data);
    })
    .catch(error => {
        console.error('Error sending data:', error);
    });
