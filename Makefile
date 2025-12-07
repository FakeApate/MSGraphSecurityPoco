# ----------------------------------------
# Paths
# ----------------------------------------
WORKSPACE            := $(shell pwd)
POCO_INPUT           := $(WORKSPACE)/MSGraphSecurityPoco/generated/poco.cs
POCO_OUTPUT_DIR      := $(WORKSPACE)/MSGraphSecurityPoco
O2P_CONFIG           := o2p_config.txt
SPLITTER_PROJECT     := PocoSplitter

# ----------------------------------------
# Default target
# ----------------------------------------
.PHONY: all
all: generate split

# ----------------------------------------
# Generate POCO (equivalent to VS Code task "Generate POCO")
# ----------------------------------------
.PHONY: generate
generate: $(POCO_INPUT)

$(POCO_INPUT):
	dotnet tool run dotnet-o2pgen -- @$(O2P_CONFIG)

# ----------------------------------------
# Split POCO (equivalent to VS Code task "Split POCO")
# ----------------------------------------
.PHONY: split
split: $(POCO_INPUT)
	dotnet run --project $(SPLITTER_PROJECT) -- \
		"$(POCO_INPUT)" \
		"$(POCO_OUTPUT_DIR)"

# ----------------------------------------
# Clean all generated outputs
# ----------------------------------------
.PHONY: clean
clean:
	rm -r $(POCO_OUTPUT_DIR)/{generated,bin,obj} || true
	rm -r $(SPLITTER_PROJECT)/{bin,obj} || true
	echo "Clean complete."
