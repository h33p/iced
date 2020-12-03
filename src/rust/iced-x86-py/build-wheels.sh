#!/bin/bash
set -e

curl https://sh.rustup.rs | sh -s -- -y --profile=minimal
export PATH="$HOME/.cargo/bin:$PATH"

# See .github/workflows/build.yml on how to add/remove Python verions
for PYBIN in /opt/python/cp{36,37,38,39}*/bin; do
	# Make sure the files don't get extra *.so files (should be 1 per file)
	rm -rf build/
	"$PYBIN/pip" install -U pip setuptools wheel setuptools-rust
	"$PYBIN/python" setup.py bdist_wheel
done
rm -rf build/

for whl in dist/*.whl; do
	auditwheel repair "$whl" -w dist/
done
rm dist/*-linux*.whl
