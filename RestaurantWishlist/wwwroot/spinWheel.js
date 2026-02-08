window.spinWheel = {
    getCenteredIndex: (container) => {
        const rect = container.getBoundingClientRect();
        const centerY = rect.top + rect.height / 2;

        let closest = 0;
        let minDist = Infinity;

        [...container.children].forEach((el, i) => {
            const r = el.getBoundingClientRect();
            const elCenter = r.top + r.height / 2;
            const dist = Math.abs(centerY - elCenter);

            if (dist < minDist) {
                minDist = dist;
                closest = i;
            }
        });

        return closest;
    },

    scrollToIndex: (container, index) => {
        const el = container.children[index];
        if (!el) return;

        el.scrollIntoView({
            behavior: "smooth",
            block: "center"
        });
    }
};