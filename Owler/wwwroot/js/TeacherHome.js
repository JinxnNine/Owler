// Get elements
const currentMonthYearElement = document.getElementById('currentMonthYear');
const calendarBody = document.getElementById('calendar-body');
const prevMonthBtn = document.getElementById('prevMonthBtn');
const nextMonthBtn = document.getElementById('nextMonthBtn');

// Get today's date
let today = new Date();
let currentMonth = today.getMonth();
let currentYear = today.getFullYear();

// Add event listeners to prev/next buttons
prevMonthBtn.addEventListener('click', () => {
    currentMonth--;
    if (currentMonth < 0) {
        currentMonth = 11;
        currentYear--;
    }
    renderCalendar(currentMonth, currentYear);
});

nextMonthBtn.addEventListener('click', () => {
    currentMonth++;
    if (currentMonth > 11) {
        currentMonth = 0;
        currentYear++;
    }
    renderCalendar(currentMonth, currentYear);
});

// Render calendar
function renderCalendar(month, year) {
    // Update current month and year
    currentMonthYearElement.textContent = `${getMonthName(month)} ${year}`;

    // Clear previous calendar
    calendarBody.innerHTML = '';

    // Get the first day of the month
    const firstDay = new Date(year, month, 1).getDay();

    // Get the number of days in the month
    const totalDays = new Date(year, month + 1, 0).getDate();

    // Create calendar cells
    let date = 1;
    for (let i = 0; i < 6; i++) {
        const row = document.createElement('tr');
        for (let j = 0; j < 7; j++) {
            const cell = document.createElement('td');
            if (i === 0 && j < firstDay) {
                cell.textContent = '';
            } else if (date > totalDays) {
                break;
            } else {
                cell.textContent = date;
                cell.addEventListener('click', function() {
                    // Remove previous selection
                    const selected = document.querySelector('.selected');
                    if (selected) {
                        selected.classList.remove('selected');
                    }
                    // Highlight the clicked date
                    cell.classList.add('selected');
                });
                date++;
            }
            row.appendChild(cell);
        }
        calendarBody.appendChild(row);
    }
}

// Helper function to get month name
function getMonthName(monthIndex) {
    const months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
    return months[monthIndex];
}

// Render initial calendar
renderCalendar(currentMonth, currentYear);