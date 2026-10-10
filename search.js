(function() {
    'use strict';

    // Tab switching
    document.querySelectorAll('.tab-btn').forEach(function(btn) {
        btn.addEventListener('click', function() {
            const tabId = this.getAttribute('data-tab');

            document.querySelectorAll('.tab-btn').forEach(b => b.classList.remove('active'));
            this.classList.add('active');

            document.querySelectorAll('.tab-content').forEach(c => c.classList.remove('active'));
            const target = document.getElementById(tabId);
            if (target) target.classList.add('active');
        });
    });
})();